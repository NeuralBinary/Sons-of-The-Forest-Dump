using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	public class SalmonSpawner : RandomPrefabInstance
	{
		// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x334FB00", Offset = "0x334E100", VA = "0x18334FB00")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x334FE80", Offset = "0x334E480", VA = "0x18334FE80")]
		private void DrawJumpArc()
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x3350A50", Offset = "0x334F050", VA = "0x183350A50")]
		public SalmonSpawner()
		{
		}

		// Token: 0x04002011 RID: 8209
		[Token(Token = "0x4002011")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationCurve _visualJumpArc;

		// Token: 0x04002012 RID: 8210
		[Token(Token = "0x4002012")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _visualArcStartColor;

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _visualArcEndColor;
	}
}
