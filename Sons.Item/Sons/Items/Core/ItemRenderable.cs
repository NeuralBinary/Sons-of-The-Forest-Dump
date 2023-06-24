using System;
using System.Collections.Generic;
using Endnight.Rendering;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Serialization;

namespace Sons.Items.Core
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[ExecuteAlways]
	public class ItemRenderable : AssetReferenceRenderable
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x1700004D")]
		public int ItemId
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xAFF460", Offset = "0xAFDA60", VA = "0x180AFF460")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x30B0DB0", Offset = "0x30AF3B0", VA = "0x1830B0DB0")]
		public void SetItemId(int itemId)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xA2FF40", Offset = "0xA2E540", VA = "0x180A2FF40")]
		public void SetAnimatedRenderable(AssetReference value)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x30AEC60", Offset = "0x30AD260", VA = "0x1830AEC60")]
		public bool GetUseSheenMaterial()
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x30B0E90", Offset = "0x30AF490", VA = "0x1830B0E90")]
		public void SetUseSheenMaterial(bool value)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x30B0EA0", Offset = "0x30AF4A0", VA = "0x1830B0EA0", Slot = "8")]
		protected override void UpdateCollisionLink(Transform parent)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x30B0FE0", Offset = "0x30AF5E0", VA = "0x1830B0FE0", Slot = "4")]
		protected override Transform GetParent()
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2962930", Offset = "0x2960F30", VA = "0x182962930")]
		public void ShouldCreateRenderableAsChild(bool shouldBeChild)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x30B10D0", Offset = "0x30AF6D0", VA = "0x1830B10D0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x30B10D0", Offset = "0x30AF6D0", VA = "0x1830B10D0")]
		private void FixSpawnInEditorOnly()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x30B10F0", Offset = "0x30AF6F0", VA = "0x1830B10F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x30B0E90", Offset = "0x30AF490", VA = "0x1830B0E90")]
		public void UseSheenMaterial(bool enable)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x30B1100", Offset = "0x30AF700", VA = "0x1830B1100")]
		private AssetReference GetCurrentRenderable()
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x30B1200", Offset = "0x30AF800", VA = "0x1830B1200")]
		public void UseAnimated(bool value)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x30B1210", Offset = "0x30AF810", VA = "0x1830B1210", Slot = "6")]
		protected override AssetReference GetActiveAssetReference()
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x30B1340", Offset = "0x30AF940", VA = "0x1830B1340", Slot = "7")]
		protected override void OnLoadDone(AsyncOperationHandle<GameObject> handle)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x30B1930", Offset = "0x30AFF30", VA = "0x1830B1930")]
		private static void ApplySheenMaterial(IEnumerable<Renderer> renderers, bool useMaskMap, int getInstanceID)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x30B1D00", Offset = "0x30B0300", VA = "0x1830B1D00")]
		public void SetSkipOnValidate(bool value)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x30B1D10", Offset = "0x30B0310", VA = "0x1830B1D10")]
		public ItemRenderable()
		{
		}

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xD0")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _itemId;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool _hasVariations;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xD5")]
		[SerializeField]
		private bool _useVariations;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<AssetReference> _renderableVariations;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xE0")]
		[FormerlySerializedAs("_destroyComponentInsteadOfObjectOnceLoaded")]
		[SerializeField]
		protected bool _createRenderableAsChild;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xE1")]
		[SerializeField]
		private bool _useAnimated;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[FormerlySerializedAs("AnimatedRenderable")]
		private AssetReference _animatedRenderable;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RuntimeAnimatorController _overrideAnimatorController;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _playOnLoad;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xF9")]
		[SerializeField]
		private bool _useSheenMaterial;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xFA")]
		[SerializeField]
		private bool _sheenUsesMaskMap;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xFB")]
		[HideInInspector]
		[SerializeField]
		private bool SpawnInEditorOnly;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private bool _skipOnValidate;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x100")]
		private int _assignedRenderableIndex;
	}
}
