using Iot.Device.SenseHat;
using System.Drawing;

namespace SenseHat.BusyLight.WebApi.Services
{
    public class SenseHatService : ISenseHatService
    {
        private readonly SenseHatLedMatrix ledMatrix;

        public SenseHatService()
        {
            ledMatrix = new SenseHatLedMatrixI2c();
        }

        public void Fill(Color color)
        {
            ledMatrix.Fill(color);
        }
    }
}
