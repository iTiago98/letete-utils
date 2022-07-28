using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Letete.Utils.Runtime
{
	public static class ColorExtensions
	{
		public static void SetRed(this Image image, float value)
        {
			image.color = new Color
				(
					value,
					image.color.g,
					image.color.b,
					image.color.a
				);
        }

		public static void SetGreen(this Image image, float value)
		{
			image.color = new Color
				(
					image.color.r,
					value,
					image.color.b,
					image.color.a
				);
		}

		public static void SetBlue(this Image image, float value)
		{
			image.color = new Color
				(
					image.color.r,
					image.color.g,
					value,
					image.color.a
				);
		}

		public static void SetAlpha(this Image image, float value)
        {
			image.color = new Color
				(
					image.color.r,
					image.color.g,
					image.color.b,
					value
				);
		}

		public static void SetRed(this TMP_Text text, float value)
		{
			text.color = new Color
				(
					value,
					text.color.g,
					text.color.b,
					text.color.a
				);
		}

		public static void SetGreen(this TMP_Text text, float value)
		{
			text.color = new Color
				(
					text.color.r,
					value,
					text.color.b,
					text.color.a
				);
		}

		public static void SetBlue(this TMP_Text text, float value)
		{
			text.color = new Color
				(
					text.color.r,
					text.color.g,
					value,
					text.color.a
				);
		}

		public static void SetAlpha(this TMP_Text text, float value)
		{
			text.color = new Color
				(
					text.color.r,
					text.color.g,
					text.color.b,
					value
				);
		}
	}
}