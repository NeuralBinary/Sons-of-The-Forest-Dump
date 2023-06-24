using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[AddComponentMenu("Sons/Weapon/DismemberMaterialRenderer")]
	public class DismemberMaterialRenderer : MonoBehaviour
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2B11600", Offset = "0x2B0FC00", VA = "0x182B11600")]
		private void OnValidate()
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x1700004D")]
		public bool IsFresh
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x620360", Offset = "0x61E960", VA = "0x180620360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2B11730", Offset = "0x2B0FD30", VA = "0x182B11730")]
		public void SetSourceLimbProps(VailActorTypeId actorType, Color bloodReveal, bool isFresh)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2B11750", Offset = "0x2B0FD50", VA = "0x182B11750")]
		public Material GetMaterialForPerishableState(PerishableItemData.State perishableState)
		{
			return null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2B11920", Offset = "0x2B0FF20", VA = "0x182B11920")]
		private void ApplySettings()
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2B11930", Offset = "0x2B0FF30", VA = "0x182B11930")]
		public void RefreshVisuals()
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2B11AE0", Offset = "0x2B100E0", VA = "0x182B11AE0")]
		public void RefreshMaterial(Renderer partRenderer, int sectionIdx)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x2B11DA0", Offset = "0x2B103A0", VA = "0x182B11DA0")]
		private static void ApplyMaterial(Renderer partRenderer, int sectionIndex, Material materialInstance)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x2B12000", Offset = "0x2B10600", VA = "0x182B12000")]
		private void CleanupMaterialInstance()
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2B12130", Offset = "0x2B10730", VA = "0x182B12130")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DismemberMaterialRenderer()
		{
		}

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _sectionIndex;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private DismemberMaterialRenderer.PartType _partType;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DismemberMaterialRenderer.DismemberModel[] _modelVariations;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x38")]
		private VailActorTypeId _actorTypeId;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x3C")]
		private Color _bloodReveal;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x4C")]
		private bool _isFresh;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x50")]
		private Material _materialInstance;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int RedChannelProp;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int GreenChannelProp;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int BlueChannelProp;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int AlphaChannelProp;

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		[Serializable]
		private class DismemberModel
		{
			// Token: 0x0600044D RID: 1101 RVA: 0x00003CF0 File Offset: 0x00001EF0
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2B12310", Offset = "0x2B10910", VA = "0x182B12310")]
			public bool MatchesCharacterType(VailActorTypeId actorTypeId)
			{
				return default(bool);
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DismemberModel()
			{
			}

			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			[FieldOffset(Offset = "0x10")]
			public DismemberMaterialRenderer.DismemberCharacterType _characterType;

			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			[FieldOffset(Offset = "0x18")]
			public Renderer _renderer;
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		private enum PartType
		{
			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			Limb,
			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			Head
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		private enum DismemberCharacterType
		{
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			None,
			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			MaleCannibal,
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			FemaleCannibal
		}
	}
}
