using AWS2018.Datas.KMAProtocols;

namespace AWS2018.Controller.ViewInterface
{
    public interface IDisplay
    {
        void SetDisplayControl(DataLogger controller);
        bool Display(KMA2Weather datas, double rain);
        bool Display(KMA3Weather datas, double rain);
        // bool display(MODEL.KMA3 datas);
    }
}
