using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class UIAnimator
{
    public static async Task FadeInForm(Form form, int duration = 600)
    {
        form.Opacity = 0;

        int steps = 40;

        for (int i = 0; i <= steps; i++)
        {
            form.Opacity = (double)i / steps;

            await Task.Delay(duration / steps);
        }

        form.Opacity = 1;
    }

    public static async Task FadeOutForm(Form form, int duration = 500)
    {
        int steps = 40;

        for (int i = steps; i >= 0; i--)
        {
            form.Opacity = (double)i / steps;

            await Task.Delay(duration / steps);
        }
    }

    public static async Task FadeInControl(Control control, int duration = 500)
    {
        Bitmap bmp = new Bitmap(control.Width, control.Height);

        control.DrawToBitmap(
            bmp,
            new Rectangle(
                0,
                0,
                control.Width,
                control.Height));

        control.Visible = true;

        Form parent = control.FindForm();

        PictureBox overlay = new PictureBox();

        overlay.Size = control.Size;
        overlay.Location = control.Location;
        overlay.BackColor = Color.Transparent;

        parent.Controls.Add(overlay);

        control.Visible = false;


        int steps = 30;


        for (int i = 0; i <= steps; i++)
        {
            float alpha = i / (float)steps;

            overlay.Image = SetOpacity(bmp, alpha);

            await Task.Delay(duration / steps);
        }


        parent.Controls.Remove(overlay);

        control.Visible = true;
    }

    private static Bitmap SetOpacity(Bitmap image, float opacity)
    {
        Bitmap bmp = new Bitmap(
            image.Width,
            image.Height);


        using (Graphics g = Graphics.FromImage(bmp))
        {
            ColorMatrix matrix = new ColorMatrix
            {
                Matrix33 = opacity
            };


            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(matrix);


            g.DrawImage(
                image,
                new Rectangle(
                    0,
                    0,
                    bmp.Width,
                    bmp.Height),
                0,
                0,
                image.Width,
                image.Height,
                GraphicsUnit.Pixel,
                attributes);
        }


        return bmp;
    }

    public static async Task SlideFadeIn(
    Control control,
    int distance = 100,
    int duration = 600)
    {
        Form form = control.FindForm();

        Point target = control.Location;

        control.Visible = true;


        Bitmap bmp = new Bitmap(
            control.Width,
            control.Height);


        control.DrawToBitmap(
            bmp,
            new Rectangle(
                0,
                0,
                control.Width,
                control.Height));


        PictureBox overlay = new PictureBox();

        overlay.Size = control.Size;
        overlay.Image = bmp;
        overlay.BackColor = Color.Transparent;


        form.Controls.Add(overlay);


        control.Visible = false;


        overlay.Location = new Point(
            target.X - distance,
            target.Y);


        int steps = 40;


        for (int i = 0; i <= steps; i++)
        {
            float progress = i / (float)steps;


            float ease =
                1 - (float)Math.Pow(1 - progress, 3);


            overlay.Left =
                target.X - distance +
                (int)(distance * ease);


            overlay.Image =
                SetOpacity(bmp, progress);


            await Task.Delay(duration / steps);
        }
        form.Controls.Remove(overlay);
        control.Location = target;
        control.Visible = true;
    }
}