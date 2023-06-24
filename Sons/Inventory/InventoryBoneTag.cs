using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	public class InventoryBoneTag : MonoBehaviour
	{
		// Token: 0x060027EF RID: 10223 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0xA6DCC0", Offset = "0xA6C2C0", VA = "0x180A6DCC0")]
		public Quaternion GetOriginalBoneRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x33D00B0", Offset = "0x33CE6B0", VA = "0x1833D00B0")]
		private void Awake()
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryBoneTag()
		{
		}

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x20")]
		public InventoryBoneTag.Type _type;

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion _originalRotation;

		// Token: 0x02000604 RID: 1540
		[Token(Token = "0x2000604")]
		public enum Type
		{
			// Token: 0x04002427 RID: 9255
			[Token(Token = "0x4002427")]
			Spine,
			// Token: 0x04002428 RID: 9256
			[Token(Token = "0x4002428")]
			Top,
			// Token: 0x04002429 RID: 9257
			[Token(Token = "0x4002429")]
			Bottom,
			// Token: 0x0400242A RID: 9258
			[Token(Token = "0x400242A")]
			End
		}
	}
}
