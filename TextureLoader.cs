using System;
using System.IO;

public class TextureLoader
{
		Texture2D texture = null;
	public Texture2D Texture2DFromFile(string filePath)
	{
		if (File.Exists(filePath))
		{
			byte[] fileData = File.ReadAllBytes(filePath);
			texture = new Texture2D(2, 2);
			texture.LoadImage(fileData);
		}
		return texture;
	}
	public Texture2D NormalMapFromFile(string filePath, float strength)
	{
		if (File.Exists(filePath))
		{
			byte[] fileData = File.ReadAllBytes(filePath);
			texture = new Texture2D(2, 2);
			texture.LoadImage(fileData);
			texture = NormalMap(texture, strength);
		}
		return texture;
	}
	public Texture2D TgaFromFile(string filePath)
    {
		Texture2D tex = null;
		tex = TGALoader.LoadTGA(filePath);
		if (tex == null || tex.width == 0 && tex.width == 0)
			tex = TGALoader.LoadTGA2(filePath);
		return tex;
    }
	public Sprite SpriteFromTexture2D(Texture2D texture2d)
    {
		if (texture2d != null)
			return Sprite.Create(texture2d, new Rect(Vector2.zero, new Vector2(texture2d.width, texture2d.height)), Vector2.zero);
		else return null;
    }
	private Texture2D NormalMap(Texture2D source, float strength)
	{
		strength = Mathf.Clamp(strength, 0.0F, 1.0F);

		Texture2D normalTexture;
		float xLeft, xRight, yUp, yDown, yDelta, xDelta;

		normalTexture = new Texture2D(source.width, source.height, TextureFormat.ARGB32, true);

		for (int y = 0; y < normalTexture.height; y++)
		{
			for (int x = 0; x < normalTexture.width; x++)
			{
				xLeft = source.GetPixel(x - 1, y).grayscale * strength;
				xRight = source.GetPixel(x + 1, y).grayscale * strength;
				yUp = source.GetPixel(x, y - 1).grayscale * strength;
				yDown = source.GetPixel(x, y + 1).grayscale * strength;
				xDelta = (xLeft - xRight + 1) * 0.5f;
				yDelta = (yUp - yDown + 1) * 0.5f;
				normalTexture.SetPixel(x, y, new Color(xDelta, yDelta, 1.0f, yDelta));
			}
		}
		normalTexture.Apply();

		return normalTexture;
	}
}
