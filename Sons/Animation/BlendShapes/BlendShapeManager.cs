using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x02000964 RID: 2404
	[Token(Token = "0x2000964")]
	public class BlendShapeManager : MonoBehaviour
	{
		// Token: 0x060045A2 RID: 17826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x3667240", Offset = "0x3665840", VA = "0x183667240")]
		private void OnValidate()
		{
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A3")]
		[Address(RVA = "0x36676D0", Offset = "0x3665CD0", VA = "0x1836676D0")]
		public void SetBlendShape(int index, float factor)
		{
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x36677D0", Offset = "0x3665DD0", VA = "0x1836677D0")]
		public void SetBlendShape(string id, float factor)
		{
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x3667900", Offset = "0x3665F00", VA = "0x183667900")]
		public int GetIntId(string stringId)
		{
			return 0;
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		public List<string> GetAllIds()
		{
			return null;
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BlendShapeManager()
		{
		}

		// Token: 0x04004816 RID: 18454
		[Token(Token = "0x4004816")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x04004817 RID: 18455
		[Token(Token = "0x4004817")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _blendShapeCount;

		// Token: 0x04004818 RID: 18456
		[Token(Token = "0x4004818")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _blendShapeNames;

		// Token: 0x04004819 RID: 18457
		[Token(Token = "0x4004819")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Mesh _skinnedMesh;
	}
}
