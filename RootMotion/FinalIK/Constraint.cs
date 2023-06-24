using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Serializable]
	public abstract class Constraint
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x28F83E0", Offset = "0x28F69E0", VA = "0x1828F83E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600012D RID: 301
		[Token(Token = "0x600012D")]
		public abstract void UpdateConstraint();

		// Token: 0x0600012E RID: 302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected Constraint()
		{
		}

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x18")]
		public float weight;
	}
}
