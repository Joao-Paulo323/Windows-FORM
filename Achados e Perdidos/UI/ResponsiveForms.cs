using System.Drawing;
using System.Windows.Forms;

namespace AchadosPerdidos.UI;

/// <summary>Maximiza formulários e mantém os controles de diálogos centralizados.
/// O menu principal usa seu próprio layout Dock/Anchor responsivo.</summary>
internal static class ResponsiveForms
{
    public static void Enable(Form form, bool centerContent = true)
    {
        var original = form.ClientSize;
        var positions = form.Controls.Cast<Control>()
            .Where(c => c.Dock == DockStyle.None)
            .ToDictionary(c => c, c => c.Location);

        form.FormBorderStyle = FormBorderStyle.Sizable;
        form.MaximizeBox = true;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.WindowState = FormWindowState.Maximized;

        if (!centerContent) return;
        void Reposition(object? sender, EventArgs args)
        {
            // Nunca desloque para posições negativas em telas pequenas.
            var offsetX = Math.Max(0, (form.ClientSize.Width - original.Width) / 2);
            var offsetY = Math.Max(0, (form.ClientSize.Height - original.Height) / 2);
            foreach (var entry in positions)
            {
                if (entry.Key.IsDisposed) continue;
                entry.Key.Location = new Point(entry.Value.X + offsetX, entry.Value.Y + offsetY);
            }
        }
        form.ClientSizeChanged += Reposition;
        Reposition(form, EventArgs.Empty);
    }
}
