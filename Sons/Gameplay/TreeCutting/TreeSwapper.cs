using System;
using Assemblies.Sons.VFX;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.TerrainDetail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2000838")]
	[AddComponentMenu("Sons/Gameplay/TreeCutting/TreeSwapper")]
	public class TreeSwapper : MonoBehaviour, IDamage, IVailActorInteract, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06003B8E RID: 15246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x35902C0", Offset = "0x358E8C0", VA = "0x1835902C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x3590560", Offset = "0x358EB60", VA = "0x183590560")]
		public void Awake()
		{
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x3590570", Offset = "0x358EB70", VA = "0x183590570")]
		private void RegisterCallbacks()
		{
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x3590970", Offset = "0x358EF70", VA = "0x183590970")]
		public void OnDestroy()
		{
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x3590C00", Offset = "0x358F200", VA = "0x183590C00")]
		public void Setup(GameObject treeCutPrefab)
		{
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public GameObject GetTreeCutPrefab()
		{
			return null;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x3590DF0", Offset = "0x358F3F0", VA = "0x183590DF0")]
		private void OnWorldObjectLocatorSourceChanged(WorldObjectLocator worldObjectLocator)
		{
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x3590EB0", Offset = "0x358F4B0", VA = "0x183590EB0")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state, bool fromSave)
		{
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x3591070", Offset = "0x358F670", VA = "0x183591070", Slot = "4")]
		public void Damage(Vector3 hitPosition, Vector3 direction, Transform sender)
		{
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x35913C0", Offset = "0x358F9C0", VA = "0x1835913C0")]
		public TreeCutManager SwapInCuttableTree()
		{
			return null;
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x3591C00", Offset = "0x3590200", VA = "0x183591C00")]
		private void Despawn()
		{
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x3591D90", Offset = "0x3590390", VA = "0x183591D90", Slot = "6")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x3591E10", Offset = "0x3590410", VA = "0x183591E10", Slot = "8")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x3592210", Offset = "0x3590810", VA = "0x183592210")]
		public void InstantCutForceFall(Vector3 direction)
		{
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x3592270", Offset = "0x3590870", VA = "0x183592270")]
		private void TestInstantCut()
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x3592370", Offset = "0x3590970", VA = "0x183592370")]
		public TreeSwapper()
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "10")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x6003BA2")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_treeToCutDown")]
		private GameObject _treeToCutDownPrefab;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("PreserveParentHeirarchy")]
		private bool _preserveParentHierarchy;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MossDistribution _mossDistribution;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _explosiveDamageToFell;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x44")]
		private bool _isSwapped;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x48")]
		private Action<WorldObjectState, bool> _onWorldObjectLocatorStateChangedDelegate;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x50")]
		private Action<WorldObjectLocator> _onWorldObjectLocatorSourceChanged;
	}
}
