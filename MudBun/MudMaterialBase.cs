using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	public abstract class MudMaterialBase : MonoBehaviour
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public MudSharedMaterialBase SharedMaterial
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x23F2ED0", Offset = "0x23F14D0", VA = "0x1823F2ED0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000036F0 File Offset: 0x000018F0
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public Color Color
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x23F2F30", Offset = "0x23F1530", VA = "0x1823F2F30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x23F3020", Offset = "0x23F1620", VA = "0x1823F3020")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public Color Emission
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x23F3030", Offset = "0x23F1630", VA = "0x1823F3030")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x23F3120", Offset = "0x23F1720", VA = "0x1823F3120")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00003720 File Offset: 0x00001920
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public float Metallic
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x23F3130", Offset = "0x23F1730", VA = "0x1823F3130")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x23F3210", Offset = "0x23F1810", VA = "0x1823F3210")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public float Smoothness
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x23F3220", Offset = "0x23F1820", VA = "0x1823F3220")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x23F3300", Offset = "0x23F1900", VA = "0x1823F3300")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public int TextureIndex
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x23F3310", Offset = "0x23F1910", VA = "0x1823F3310")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x23F33F0", Offset = "0x23F19F0", VA = "0x1823F33F0")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public float SplatSize
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x23F3400", Offset = "0x23F1A00", VA = "0x1823F3400")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x23F34E0", Offset = "0x23F1AE0", VA = "0x1823F34E0")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00003780 File Offset: 0x00001980
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public float BlendTightness
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x23F34F0", Offset = "0x23F1AF0", VA = "0x1823F34F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x23F35D0", Offset = "0x23F1BD0", VA = "0x1823F35D0")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public bool ContributeMaterial
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x23F35E0", Offset = "0x23F1BE0", VA = "0x1823F35E0")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x1700006B")]
		public int MaterialHash
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x23F35F0", Offset = "0x23F1BF0", VA = "0x1823F35F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x23F36D0", Offset = "0x23F1CD0", VA = "0x1823F36D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x23F36E0", Offset = "0x23F1CE0", VA = "0x1823F36E0")]
		private void OnValidate()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x23F3770", Offset = "0x23F1D70", VA = "0x1823F3770")]
		public void MarkDirty()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x23F2E60", Offset = "0x23F1460", VA = "0x1823F2E60")]
		protected MudMaterialBase()
		{
		}

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MudSharedMaterialBase m_sharedMaterial;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null)]
		private Color m_color;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x38")]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null)]
		[SerializeField]
		private Color m_emission;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x48")]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null, Min = 0f, Max = 1f)]
		[SerializeField]
		private float m_metallic;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null, Min = 0f, Max = 1f)]
		private float m_smoothness;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null, Min = 0f, Max = 3f)]
		private int m_textureIndex;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null, Min = 0f, Max = 5f)]
		private float m_splatSize;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[ConditionalField("m_sharedMaterial", "NULL", null, null, null, null, null, Min = 0f, Max = 1f)]
		private float m_blendTightness;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool m_contributeMaterial;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x60")]
		private int m_materialHash;
	}
}
