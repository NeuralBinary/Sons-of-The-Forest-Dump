using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Endnight.Rendering
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	[ExecuteAlways]
	public class AssetReferenceRenderable : MonoBehaviour
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x17000024")]
		public bool IsObjectLoaded
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xA91C60", Offset = "0xA90260", VA = "0x180A91C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000025")]
		private UnityEvent<Transform> _onRenderableLoaded
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x17000026")]
		public bool IgnoreSkinnedMeshRenderers
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xA91D20", Offset = "0xA90320", VA = "0x180A91D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x17000027")]
		public bool UsesCustomCollider
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000028")]
		public Mesh GetCustomColliderMesh
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA91D30", Offset = "0xA90330", VA = "0x180A91D30")]
		private void Awake()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "4")]
		protected virtual Transform GetParent()
		{
			return null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		public void SetSpawnInEditorOnly(bool value)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA91D40", Offset = "0xA90340", VA = "0x180A91D40")]
		public void OnRenderableLoaded(UnityAction<Transform> callback)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA91F10", Offset = "0xA90510", VA = "0x180A91F10")]
		public void ClearOnRenderableLoadedListeners()
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA91F40", Offset = "0xA90540", VA = "0x180A91F40", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA92380", Offset = "0xA90980", VA = "0x180A92380")]
		private void SleepParentRenderable()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA92660", Offset = "0xA90C60", VA = "0x180A92660")]
		private void OnDisable()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA92670", Offset = "0xA90C70", VA = "0x180A92670")]
		private void CleanUpAddressable()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private static bool IsInPrefabEditMode(GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA92890", Offset = "0xA90E90", VA = "0x180A92890")]
		private void OnDestroy()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA92960", Offset = "0xA90F60", VA = "0x180A92960")]
		public void ShouldAddMeshColliderToRenderables(bool enable)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA92970", Offset = "0xA90F70", VA = "0x180A92970")]
		public void ShouldAddMeshColliderToRenderables(bool enable, bool useConvex)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA92980", Offset = "0xA90F80", VA = "0x180A92980")]
		private bool ShouldShowAddColliderOptions()
		{
			return default(bool);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetRenderable(AssetReference renderable)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA92990", Offset = "0xA90F90", VA = "0x180A92990")]
		public void RemoveCollider(bool remove, bool onlyIfHasChildren)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "6")]
		protected virtual AssetReference GetActiveAssetReference()
		{
			return null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA929A0", Offset = "0xA90FA0", VA = "0x180A929A0", Slot = "7")]
		protected virtual void OnLoadDone(AsyncOperationHandle<GameObject> handle)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA93250", Offset = "0xA91850", VA = "0x180A93250")]
		private void ApplyLayers(Transform objectTransform)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA935A0", Offset = "0xA91BA0", VA = "0x180A935A0")]
		private void ApplyTransformScaleSettings(Transform objectTransform)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA93890", Offset = "0xA91E90", VA = "0x180A93890")]
		private static void ClearLocalPositionAndRotation(Transform objectTransform)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA939B0", Offset = "0xA91FB0", VA = "0x180A939B0")]
		private void ApplyScaleToChild(Transform objectTransform)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA93BD0", Offset = "0xA921D0", VA = "0x180A93BD0", Slot = "8")]
		protected virtual void UpdateCollisionLink(Transform parent)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA93F40", Offset = "0xA92540", VA = "0x180A93F40")]
		private void AddColliders(Transform parent)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA943D0", Offset = "0xA929D0", VA = "0x180A943D0")]
		public void SetColliders(bool isDynamic)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA94810", Offset = "0xA92E10", VA = "0x180A94810")]
		private void RemoveCollider(GameObject colliderObject)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA94A30", Offset = "0xA93030", VA = "0x180A94A30")]
		private void SetColliderToTrigger(GameObject colliderObject)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x9962D0", Offset = "0x9948D0", VA = "0x1809962D0")]
		public void SetApplyLayerToRoot(bool value)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x66E8D0", Offset = "0x66CED0", VA = "0x18066E8D0")]
		public void SetApplyLayerToChildren(bool value)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA94B60", Offset = "0xA93160", VA = "0x180A94B60")]
		public AssetReferenceRenderable()
		{
		}

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected AssetReference _baseRenderable;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected bool _spawnInEditorOnly;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _applyLayerToRoot;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _applyLayerToChildren;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _applyScale;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Applies the scale to all the children of the AssetRenderable rather than on the AssetRenderable object itself.")]
		[SerializeField]
		private bool _applyScaleToChildren;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _scale;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		[SerializeField]
		private bool _removeCollider;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		[HideInInspector]
		private bool _removeColliderOnlyIfHasChildren;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x3E")]
		[SerializeField]
		private bool _addMeshColliderToRenderables;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x3F")]
		[SerializeField]
		private bool _ignoreSkinnedMeshRenderers;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _useCustomColliderMesh;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Mesh _customColliderMesh;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _useConvexColliders;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _colliderIsTrigger;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool _colliderIsDisabled;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x53")]
		[SerializeField]
		private bool _addRigidBody;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _isDynamic;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ShaderProxyDefinition[] _shaderProxies;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x60")]
		private bool _allowSelection;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _editorRenderable;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x70")]
		private GameObject _cachedLoadedObject;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x78")]
		private AsyncOperationHandle<GameObject> _instantiateAsyncOperationHandle;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x0")]
		private static LocalKeyword _transparentLocalKeyword;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x18")]
		private static bool _transparentLocalKeywordSetup;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xA0")]
		private int _renderableCount;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 _tempReusedVector;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<Material, Material> _swappedMaterialsCache;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<MeshCollider> _addedMeshColliders;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xC0")]
		private bool _cachedEnableCollider;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xC8")]
		protected AssetReferenceRenderableCollisionLink _collisionLink;
	}
}
