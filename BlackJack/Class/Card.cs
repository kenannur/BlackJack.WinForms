using BlackJack.Enumeration;
using System.Drawing;

namespace BlackJack.Class
{
    public class Card
    {
        public FaceColor FaceColor { get; set; }
        public FaceValue FaceValue { get; set; }
        public int Value { get; private set; }
        public Image Image { get; private set; }

        public Card(FaceColor faceColor, FaceValue faceValue)
        {
            FaceColor = faceColor;
            FaceValue = faceValue;
            SetImage();
            SetValues();
        }

        private void SetImage()
        {
            object imageObject = Resources.ResourceManager.GetObject(FaceColor.ToString() + (int)FaceValue);
            Image = (Image)imageObject;
        }

        private void SetValues()
        {
            if (FaceValue == FaceValue.Ace)
            {
                Value = 11;
            }
            else if (FaceValue == FaceValue.Jack || FaceValue == FaceValue.Queen || FaceValue == FaceValue.King)
            {
                Value = 10;
            }
            else
            {
                Value = (int)FaceValue;
            }
        }
    }
}
