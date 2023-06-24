using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000023")]
public class BoltConsole : MonoBehaviour
{
	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000124 RID: 292 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x1700003F")]
	internal static int LinesCount
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x786DD0", Offset = "0x7853D0", VA = "0x180786DD0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000125 RID: 293 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000040")]
	internal static IEnumerable<BoltConsole.Line> Lines
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x786E40", Offset = "0x785440", VA = "0x180786E40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x786E90", Offset = "0x785490", VA = "0x180786E90")]
	public static void Write(string line, Color color)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x7872D0", Offset = "0x7858D0", VA = "0x1807872D0")]
	public static void Write(string line)
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x787340", Offset = "0x785940", VA = "0x180787340")]
	internal static void WriteReal(string line, Color color)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x787630", Offset = "0x785C30", VA = "0x180787630")]
	private void Awake()
	{
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x7876D0", Offset = "0x785CD0", VA = "0x1807876D0")]
	internal static void Clear()
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x787920", Offset = "0x785F20", VA = "0x180787920")]
	internal static void LinesRefresh()
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x787C90", Offset = "0x786290", VA = "0x180787C90")]
	private void OnGUI()
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x788100", Offset = "0x786700", VA = "0x180788100")]
	private Rect GetRect(int line)
	{
		return default(Rect);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x7881D0", Offset = "0x7867D0", VA = "0x1807881D0")]
	public BoltConsole()
	{
	}

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x0")]
	private static int _changed;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly object _mutex;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x10")]
	private static readonly BoltRingBuffer<BoltConsole.Line> _lines;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x18")]
	private static readonly BoltRingBuffer<BoltConsole.Line> _linesRender;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float consoleHeight;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int lineHeight;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal bool visible;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	internal KeyCode toggleKey;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int padding;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int fontSize;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int inset;

	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	internal struct Line
	{
		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		public Color color;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x10")]
		public string text;
	}
}
