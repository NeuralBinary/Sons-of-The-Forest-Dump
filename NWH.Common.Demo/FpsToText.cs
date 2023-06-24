using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace NWH.Common.Demo
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[RequireComponent(typeof(Text))]
	public class FpsToText : MonoBehaviour
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x26EB710", Offset = "0x26E9D10", VA = "0x1826EB710", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x26EB960", Offset = "0x26E9F60", VA = "0x1826EB960", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x26EBAF0", Offset = "0x26EA0F0", VA = "0x1826EBAF0", Slot = "6")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x26EBB40", Offset = "0x26EA140", VA = "0x1826EBB40", Slot = "7")]
		protected virtual void SingleFrame()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x26EBC20", Offset = "0x26EA220", VA = "0x1826EBC20", Slot = "8")]
		protected virtual void Group()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x26EBDC0", Offset = "0x26EA3C0", VA = "0x1826EBDC0", Slot = "9")]
		protected virtual int GetSystemFramerate()
		{
			return 0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x26EBE70", Offset = "0x26EA470", VA = "0x1826EBE70")]
		public FpsToText()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		public bool groupSampling;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x24")]
		public int sampleSize;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x28")]
		public int updateTextEvery;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x2C")]
		public bool smoothed;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x2D")]
		public bool forceIntResult;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x2E")]
		public bool useSystemTick;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x2F")]
		public bool useColors;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		public Color good;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x40")]
		public Color okay;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x50")]
		public Color bad;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x60")]
		public int okayBelow;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x64")]
		public int badBelow;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x68")]
		private Text _targetText;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x70")]
		private float[] _fpsSamples;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x78")]
		private int _sampleIndex;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x7C")]
		private int _textUpdateIndex;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x80")]
		private float _fps;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x84")]
		private int _sysLastSysTick;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x88")]
		private int _sysLastFrameRate;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x8C")]
		private int _sysFrameRate;
	}
}
