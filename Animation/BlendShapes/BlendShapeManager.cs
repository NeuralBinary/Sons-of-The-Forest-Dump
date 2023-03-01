using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x020008E4 RID: 2276
	[Token(Token = "0x20008E4")]
	public class BlendShapeManager : MonoBehaviour
	{
		// Token: 0x06003DD7 RID: 15831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x2F0DE40", Offset = "0x2F0CE40", VA = "0x182F0DE40")]
		private void OnValidate()
		{
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x2F0E180", Offset = "0x2F0D180", VA = "0x182F0E180")]
		public void SetBlendShape(int index, float factor)
		{
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x2F0E070", Offset = "0x2F0D070", VA = "0x182F0E070")]
		public void SetBlendShape(string id, float factor)
		{
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x2F0DDE0", Offset = "0x2F0CDE0", VA = "0x182F0DDE0")]
		public int GetIntId(string stringId)
		{
			return default(int);
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
		public List<string> GetAllIds()
		{
			return null;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BlendShapeManager()
		{
		}

		// Token: 0x0400419C RID: 16796
		[Token(Token = "0x400419C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x0400419D RID: 16797
		[Token(Token = "0x400419D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _blendShapeCount;

		// Token: 0x0400419E RID: 16798
		[Token(Token = "0x400419E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _blendShapeNames;

		// Token: 0x0400419F RID: 16799
		[Token(Token = "0x400419F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Mesh _skinnedMesh;
	}
}
