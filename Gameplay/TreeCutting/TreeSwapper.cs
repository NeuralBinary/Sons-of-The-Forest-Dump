using System;
using Assemblies.Sons.VFX;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.TerrainDetail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	[AddComponentMenu("Sons/Gameplay/TreeCutting/TreeSwapper")]
	public class TreeSwapper : MonoBehaviour, IDamage, IVailActorInteract, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06002DA2 RID: 11682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0x2E1E880", Offset = "0x2E1D880", VA = "0x182E1E880")]
		private void OnValidate()
		{
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x2E1DF50", Offset = "0x2E1CF50", VA = "0x182E1DF50")]
		public void Awake()
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x2E1EB70", Offset = "0x2E1DB70", VA = "0x182E1EB70")]
		private void RegisterCallbacks()
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x2E1E330", Offset = "0x2E1D330", VA = "0x182E1E330")]
		public void OnDestroy()
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x2E1EDE0", Offset = "0x2E1DDE0", VA = "0x182E1EDE0")]
		public void Setup(GameObject treeCutPrefab)
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public GameObject GetTreeCutPrefab()
		{
			return null;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x2E1E980", Offset = "0x2E1D980", VA = "0x182E1E980")]
		private void OnWorldObjectLocatorSourceChanged(WorldObjectLocator worldObjectLocator)
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x2E1EA00", Offset = "0x2E1DA00", VA = "0x182E1EA00")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state)
		{
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x2E1DF60", Offset = "0x2E1CF60", VA = "0x182E1DF60", Slot = "4")]
		public void Damage(Vector3 hitPosition, Vector3 direction, Transform sender)
		{
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x2E1EEB0", Offset = "0x2E1DEB0", VA = "0x182E1EEB0")]
		public TreeCutManager SwapInCuttableTree()
		{
			return null;
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x2E1E190", Offset = "0x2E1D190", VA = "0x182E1E190")]
		private void Despawn()
		{
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0x2E1E250", Offset = "0x2E1D250", VA = "0x182E1E250", Slot = "6")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "7")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x2E1E4E0", Offset = "0x2E1D4E0", VA = "0x182E1E4E0", Slot = "8")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x2E1E2D0", Offset = "0x2E1D2D0", VA = "0x182E1E2D0")]
		public void InstantCutForceFall(Vector3 direction)
		{
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x2E1F1A0", Offset = "0x2E1E1A0", VA = "0x182E1F1A0")]
		private void TestInstantCut()
		{
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x2E1F270", Offset = "0x2E1E270", VA = "0x182E1F270")]
		public TreeSwapper()
		{
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "10")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x6002DB6")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040028C4 RID: 10436
		[Token(Token = "0x40028C4")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_treeToCutDown")]
		[SerializeField]
		private GameObject _treeToCutDownPrefab;

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("PreserveParentHeirarchy")]
		[SerializeField]
		private bool _preserveParentHierarchy;

		// Token: 0x040028C6 RID: 10438
		[Token(Token = "0x40028C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MossDistribution _mossDistribution;

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x040028C8 RID: 10440
		[Token(Token = "0x40028C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _explosiveDamageToFell;

		// Token: 0x040028C9 RID: 10441
		[Token(Token = "0x40028C9")]
		[FieldOffset(Offset = "0x44")]
		private bool _isSwapped;

		// Token: 0x040028CA RID: 10442
		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x48")]
		private Action<WorldObjectState> _onWorldObjectLocatorStateChangedDelegate;

		// Token: 0x040028CB RID: 10443
		[Token(Token = "0x40028CB")]
		[FieldOffset(Offset = "0x50")]
		private Action<WorldObjectLocator> _onWorldObjectLocatorSourceChanged;
	}
}
