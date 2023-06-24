using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class AnimateLinkTextGui : MonoBehaviour
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3000060", Offset = "0x2FFE660", VA = "0x183000060")]
		private void OnValidate()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3000190", Offset = "0x2FFE790", VA = "0x183000190")]
		private void Update()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3000350", Offset = "0x2FFE950", VA = "0x183000350")]
		private void Initialize()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x28C7AC0", Offset = "0x28C60C0", VA = "0x1828C7AC0")]
		public AnimateLinkTextGui()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkTextGui _linkTextGui;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _loop;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _speed;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x30")]
		private string _sourceString;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x38")]
		private bool _initialized;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x3C")]
		private float _startTime;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x40")]
		private bool _completed;
	}
}
