using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Карта
{
    public partial class Карта : Form
    {
        private GMarkerGoogle centerMarker; // Метка для центра экрана
        public Карта()
        {
            InitializeComponent();
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
                GMaps.Instance.Mode = AccessMode.ServerOnly;
                double TxBxDolgota = Convert.ToDouble(TxBxLong.Text);
                double TxBxShirota = Convert.ToDouble(TxBxWight.Text);
                gMapControl1.Position = new GMap.NET.PointLatLng(TxBxShirota, TxBxDolgota);
                gMapControl1.MinZoom = 15;
                gMapControl1.MaxZoom = 500;
                gMapControl1.Zoom = 20;
                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
                gMapControl1.PolygonsEnabled = true;
                gMapControl1.RoutesEnabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для долготы и широты");
            }
        }
        private void CreateMark_Click(object sender, EventArgs e)
        {
            try
            {
                double TxBxShirotaForName = Convert.ToDouble(TxBxWightForName.Text);
                double TxBxDolgotaForName = Convert.ToDouble(TxBxLongForName.Text);
                PointLatLng point = new PointLatLng(TxBxShirotaForName, TxBxDolgotaForName);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                string MarkerText = string.Format(TxBxMarkText.Text);
                marker.ToolTipText = MarkerText;
                string MarkerName = string.Format(TxBxMarkText.Text);
                GMapOverlay markers = new GMapOverlay(MarkerName);
                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для долготы и широты.");
            }
        }
        private void gMapControl1_OnPositionChanged(PointLatLng point)
        {
            // Обновляем координаты в TextBox'ах при перемещении карты
            Long.Text = point.Lat.ToString();
            width.Text = point.Lng.ToString();
        }
        private void gMapControl1_OnMapZoomChanged()
        {
            // Обновляем позицию маркера при изменении масштаба карты
            if (centerMarker != null)
            {
                centerMarker.Position = gMapControl1.Position;
                // Определите здесь ваш условный порог масштаба, при котором маркер будет видимым
                int zoomThreshold = 15;
                // Устанавливаем видимость маркера в зависимости от масштаба
                if (gMapControl1.Zoom >= zoomThreshold)
                {
                    centerMarker.IsVisible = true;
                }
                else
                {
                    centerMarker.IsVisible = false;
                }
            }
        }
    }
}