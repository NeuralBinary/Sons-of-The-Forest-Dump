using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
public class Readme : ScriptableObject
{
	// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public Readme()
	{
	}

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x20")]
	public string title;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x28")]
	public Readme.Section[] sections;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[Serializable]
	public class Section
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Section()
		{
		}

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		public string heading;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x20")]
		public string linkText;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x28")]
		public string url;
	}
}
