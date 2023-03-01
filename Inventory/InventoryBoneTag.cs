using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F1 RID: 1521
	[Token(Token = "0x20005F1")]
	public class InventoryBoneTag : MonoBehaviour
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x909E30", Offset = "0x908E30", VA = "0x180909E30")]
		public Quaternion GetOriginalBoneRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x2D96B50", Offset = "0x2D95B50", VA = "0x182D96B50")]
		private void Awake()
		{
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryBoneTag()
		{
		}

		// Token: 0x04002341 RID: 9025
		[Token(Token = "0x4002341")]
		[FieldOffset(Offset = "0x20")]
		public InventoryBoneTag.Type _type;

		// Token: 0x04002342 RID: 9026
		[Token(Token = "0x4002342")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion _originalRotation;

		// Token: 0x020005F2 RID: 1522
		[Token(Token = "0x20005F2")]
		public enum Type
		{
			// Token: 0x04002344 RID: 9028
			[Token(Token = "0x4002344")]
			Spine,
			// Token: 0x04002345 RID: 9029
			[Token(Token = "0x4002345")]
			Top,
			// Token: 0x04002346 RID: 9030
			[Token(Token = "0x4002346")]
			Bottom,
			// Token: 0x04002347 RID: 9031
			[Token(Token = "0x4002347")]
			End
		}
	}
}
