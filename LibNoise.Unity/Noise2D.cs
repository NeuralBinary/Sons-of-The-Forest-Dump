using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Il2CppDummyDll;
using UnityEngine;

namespace LibNoise
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class Noise2D : IDisposable
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x207BE30", Offset = "0x207A430", VA = "0x18207BE30")]
		protected Noise2D()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x207BE40", Offset = "0x207A440", VA = "0x18207BE40")]
		public Noise2D(int size)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x207BE60", Offset = "0x207A460", VA = "0x18207BE60")]
		public Noise2D(int size, ModuleBase generator)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x207BE80", Offset = "0x207A480", VA = "0x18207BE80")]
		public Noise2D(int width, int height, [Optional] ModuleBase generator)
		{
		}

		// Token: 0x1700000A RID: 10
		[Token(Token = "0x1700000A")]
		public float this[int x, int y, bool isCropped = true]
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x207C040", Offset = "0x207A640", VA = "0x18207C040")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x207C200", Offset = "0x207A800", VA = "0x18207C200")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020FC File Offset: 0x000002FC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public float Border
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public ModuleBase Generator
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x1700000D")]
		public int Height
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x1700000E")]
		public int Width
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x207C3D0", Offset = "0x207A9D0", VA = "0x18207C3D0")]
		public float[,] GetNormalizedData(bool isCropped = true, int xCrop = 0, int yCrop = 0)
		{
			return null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x207C520", Offset = "0x207AB20", VA = "0x18207C520")]
		public float[,] GetData(bool isCropped = true, int xCrop = 0, int yCrop = 0, bool isNormalized = false)
		{
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x207C6D0", Offset = "0x207ACD0", VA = "0x18207C6D0")]
		public void Clear(float value = 0f)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x207C750", Offset = "0x207AD50", VA = "0x18207C750")]
		private double GeneratePlanar(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x207C790", Offset = "0x207AD90", VA = "0x18207C790")]
		public void GeneratePlanar(double left, double right, double top, double bottom, bool isSeamless = true)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x207CC80", Offset = "0x207B280", VA = "0x18207CC80")]
		private double GenerateCylindrical(double angle, double height)
		{
			return 0.0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x207CD50", Offset = "0x207B350", VA = "0x18207CD50")]
		public void GenerateCylindrical(double angleMin, double angleMax, double heightMin, double heightMax)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x207CFD0", Offset = "0x207B5D0", VA = "0x18207CFD0")]
		private double GenerateSpherical(double lat, double lon)
		{
			return 0.0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x207D0F0", Offset = "0x207B6F0", VA = "0x18207D0F0")]
		public void GenerateSpherical(double south, double north, double west, double east)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x207D370", Offset = "0x207B970", VA = "0x18207D370")]
		public Texture2D GetTexture()
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x207D400", Offset = "0x207BA00", VA = "0x18207D400")]
		public Texture2D GetTexture(Gradient gradient)
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x207D680", Offset = "0x207BC80", VA = "0x18207D680")]
		public Texture2D GetNormalMap(float intensity)
		{
			return null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x1700000F")]
		public bool IsDisposed
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x207DA40", Offset = "0x207C040", VA = "0x18207DA40", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x207DAE0", Offset = "0x207C0E0", VA = "0x18207DAE0", Slot = "5")]
		protected virtual bool Disposing()
		{
			return default(bool);
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly double South;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly double North;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly double West;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly double East;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly double AngleMin;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly double AngleMax;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly double Left;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly double Right;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly double Top;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly double Bottom;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _width;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _height;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[,] _data;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int _ucWidth;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly int _ucHeight;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _ucBorder;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly float[,] _ucData;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _borderValue;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ModuleBase _generator;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[XmlIgnore]
		[NonSerialized]
		private bool _disposed;
	}
}
