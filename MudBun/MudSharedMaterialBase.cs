using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public class MudSharedMaterialBase : ScriptableObject
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public static event MudSharedMaterialBase.SharedMaterialChanged OnSharedMaterialChanged
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x23F9030", Offset = "0x23F7630", VA = "0x1823F9030")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x23F9140", Offset = "0x23F7740", VA = "0x1823F9140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x170000A5")]
		public int MaterialHash
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x23F9250", Offset = "0x23F7850", VA = "0x1823F9250")]
		private void OnEnable()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x23F9260", Offset = "0x23F7860", VA = "0x1823F9260")]
		private void OnValidate()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x23F92D0", Offset = "0x23F78D0", VA = "0x1823F92D0")]
		private void MarkDirty()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x23F8FF0", Offset = "0x23F75F0", VA = "0x1823F8FF0")]
		public MudSharedMaterialBase()
		{
		}

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x18")]
		public Color Color;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x28")]
		public Color Emission;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float Metallic;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float Smoothness;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 3f)]
		public int TextureIndex;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 5f)]
		public float SplatSize;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float BlendTightness;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		[SerializeField]
		private int m_materialHash;

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060003B7 RID: 951
		[Token(Token = "0x200008B")]
		public delegate void SharedMaterialChanged(UnityEngine.Object material);
	}
}
