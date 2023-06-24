using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public class SeasonalAssetSwapper : MonoBehaviour, ISeasonsReceiver
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		public void SetForceWinterAtSnowHeight(bool value)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public bool ExternallyManaged
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x9EB6D0", Offset = "0x9E9CD0", VA = "0x1809EB6D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x2B88C90", Offset = "0x2B87290", VA = "0x182B88C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2B88C90", Offset = "0x2B87290", VA = "0x182B88C90")]
		public void SetExternallyManaged(bool value)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2D45650", Offset = "0x2D43C50", VA = "0x182D45650")]
		private void Awake()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2D456B0", Offset = "0x2D43CB0", VA = "0x182D456B0")]
		private void Initialize()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2D45700", Offset = "0x2D43D00", VA = "0x182D45700")]
		private void OnEnable()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2D45760", Offset = "0x2D43D60", VA = "0x182D45760")]
		private void CacheSharedMaterials(SeasonalAssetSwapper.SeasonSwaps seasonSwap)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2D45960", Offset = "0x2D43F60", VA = "0x182D45960")]
		private void OnDisable()
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2D459C0", Offset = "0x2D43FC0", VA = "0x182D459C0", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2D459E0", Offset = "0x2D43FE0", VA = "0x182D459E0", Slot = "5")]
		private void SnowHeightChanged(float snowHeight)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2D45A20", Offset = "0x2D44020", VA = "0x182D45A20")]
		public void ApplySeason(SeasonsManager.Season applySeason)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2D45E10", Offset = "0x2D44410", VA = "0x182D45E10")]
		private void UpdateSeasonSwap(SeasonalAssetSwapper.SeasonSwaps seasonSwap, bool isActiveSeason)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2D46490", Offset = "0x2D44A90", VA = "0x182D46490")]
		private static void SwapMaterial(SeasonalAssetSwapper.SeasonSwaps.MaterialsSwap materialsSwap)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2D46690", Offset = "0x2D44C90", VA = "0x182D46690")]
		private static void SwapMesh(SeasonalAssetSwapper.SeasonSwaps.MeshSwap seasonSwapMeshSwap)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2D46830", Offset = "0x2D44E30", VA = "0x182D46830")]
		private static void SwapComponent(Component seasonSwapComponent, bool isActiveSeason)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2D46A20", Offset = "0x2D45020", VA = "0x182D46A20")]
		private void OnValidate()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2D46BE0", Offset = "0x2D451E0", VA = "0x182D46BE0")]
		private bool CheckForUniqueMesh(SeasonalAssetSwapper.SeasonSwaps seasonSwaps, string seasonName)
		{
			return default(bool);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2D46D50", Offset = "0x2D45350", VA = "0x182D46D50")]
		private bool IsApplied(SeasonalAssetSwapper.SeasonSwaps.MeshSwap eachMeshSwap)
		{
			return default(bool);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2D46F30", Offset = "0x2D45530", VA = "0x182D46F30")]
		public SeasonalAssetSwapper()
		{
		}

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _forceWinterAtSnowHeight;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SeasonalAssetSwapper.SeasonSwaps _spring;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x0")]
		private static Color _springColor;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SeasonalAssetSwapper.SeasonSwaps _summer;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SeasonalAssetSwapper.SeasonSwaps _autumn;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SeasonalAssetSwapper.SeasonSwaps _winter;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x48")]
		private SeasonsManager.Season _appliedSeason;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x4C")]
		private bool _forceOnce;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x50")]
		private float _terrainHeight;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x54")]
		private bool _appliedAboveSnowHeight;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x58")]
		private SeasonsManager.Season _activeSeason;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x5C")]
		private bool _initialized;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		[Serializable]
		public class SeasonSwaps
		{
			// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2D46FC0", Offset = "0x2D455C0", VA = "0x182D46FC0")]
			public SeasonSwaps()
			{
			}

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x10")]
			public List<SeasonalAssetSwapper.SeasonSwaps.MeshSwap> _meshSwaps;

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x18")]
			public List<SeasonalAssetSwapper.SeasonSwaps.MaterialsSwap> _materialsSwap;

			// Token: 0x04000189 RID: 393
			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x20")]
			public List<Component> _components;

			// Token: 0x02000042 RID: 66
			[Token(Token = "0x2000042")]
			[Serializable]
			public class MeshSwap
			{
				// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60001BC")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public MeshSwap()
				{
				}

				// Token: 0x0400018A RID: 394
				[Token(Token = "0x400018A")]
				[FieldOffset(Offset = "0x10")]
				public bool _isSkinned;

				// Token: 0x0400018B RID: 395
				[Token(Token = "0x400018B")]
				[FieldOffset(Offset = "0x18")]
				public MeshFilter _meshFilter;

				// Token: 0x0400018C RID: 396
				[Token(Token = "0x400018C")]
				[FieldOffset(Offset = "0x20")]
				public SkinnedMeshRenderer _skinnedMeshRenderer;

				// Token: 0x0400018D RID: 397
				[Token(Token = "0x400018D")]
				[FieldOffset(Offset = "0x28")]
				public Mesh _mesh;
			}

			// Token: 0x02000043 RID: 67
			[Token(Token = "0x2000043")]
			[Serializable]
			public class MaterialsSwap
			{
				// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60001BD")]
				[Address(RVA = "0x2D47070", Offset = "0x2D45670", VA = "0x182D47070")]
				public MaterialsSwap()
				{
				}

				// Token: 0x0400018E RID: 398
				[Token(Token = "0x400018E")]
				[FieldOffset(Offset = "0x10")]
				public Renderer _renderer;

				// Token: 0x0400018F RID: 399
				[Token(Token = "0x400018F")]
				[FieldOffset(Offset = "0x18")]
				public List<Material> _materials;

				// Token: 0x04000190 RID: 400
				[Token(Token = "0x4000190")]
				[FieldOffset(Offset = "0x20")]
				[HideInInspector]
				public List<Material> _sharedMaterials;
			}
		}
	}
}
