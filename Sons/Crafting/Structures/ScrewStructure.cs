using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006CE RID: 1742
	[Token(Token = "0x20006CE")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewStructure")]
	public class ScrewStructure : BoltEntityBehaviourWrapper<IScrewStructureWithStorageState>
	{
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06002DE9 RID: 11753 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002DEA RID: 11754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000020")]
		internal event Action<BoltEntity> OnNetworkTranslationControllerChanged
		{
			[Token(Token = "0x6002DE9")]
			[Address(RVA = "0x3442140", Offset = "0x3440740", VA = "0x183442140")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002DEA")]
			[Address(RVA = "0x34422B0", Offset = "0x34408B0", VA = "0x1834422B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEB")]
		[Address(RVA = "0x3442420", Offset = "0x3440A20", VA = "0x183442420")]
		public void SetIgnoreTranslationConstraint(bool ignore)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000618")]
		public StructureRecipe Recipe
		{
			[Token(Token = "0x6002DEC")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DED")]
		[Address(RVA = "0x3442430", Offset = "0x3440A30", VA = "0x183442430", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
		public bool IsBusy()
		{
			return default(bool);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void SetIsBusy(bool isBusy)
		{
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF0")]
		[Address(RVA = "0x3443120", Offset = "0x3441720", VA = "0x183443120", Slot = "24")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF1")]
		[Address(RVA = "0x34432E0", Offset = "0x34418E0", VA = "0x1834432E0")]
		private void Start()
		{
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x3443400", Offset = "0x3441A00", VA = "0x183443400")]
		private void OnEnable()
		{
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x34434C0", Offset = "0x3441AC0", VA = "0x1834434C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF4")]
		[Address(RVA = "0x3443560", Offset = "0x3441B60", VA = "0x183443560")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF5")]
		[Address(RVA = "0x3443570", Offset = "0x3441B70", VA = "0x183443570")]
		private void ProcessStoragePickups()
		{
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF6")]
		[Address(RVA = "0x3443B30", Offset = "0x3442130", VA = "0x183443B30")]
		private static IEnumerator SpawnItemInternal(ItemData itemData, IReadOnlyList<ItemInstance> itemInstances, int count, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF7")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
		public void SetRecipe(StructureRecipe recipe)
		{
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x3443C70", Offset = "0x3442270", VA = "0x183443C70")]
		private void HostUpdateStorageState(StructureStorage storage, int itemId, int count, int stateIndex)
		{
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x34444A0", Offset = "0x3442AA0", VA = "0x1834444A0", Slot = "25")]
		public virtual void ModifyItemCountFromClientRequest(ItemInstance itemInstance, int count, int storageIndex, BoltConnection sender)
		{
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x3444A50", Offset = "0x3443050", VA = "0x183444A50")]
		private void StorageChangedOnHost()
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		protected virtual void OnSlotAvailabilityChangedMP()
		{
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x3444F80", Offset = "0x3443580", VA = "0x183444F80")]
		public bool CanBeDismantled()
		{
			return default(bool);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x3444FB0", Offset = "0x34435B0", VA = "0x183444FB0")]
		public bool IsStoringItems()
		{
			return default(bool);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x3445120", Offset = "0x3443720", VA = "0x183445120")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x3445130", Offset = "0x3443730", VA = "0x183445130")]
		private void UpdateTranslationConstraint()
		{
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x3445330", Offset = "0x3443930", VA = "0x183445330")]
		public bool HasTranslationController()
		{
			return default(bool);
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x0000D908 File Offset: 0x0000BB08
		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x3445350", Offset = "0x3443950", VA = "0x183445350")]
		public bool TryGetTranslationController(out BoltEntity translationController)
		{
			return default(bool);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x3445620", Offset = "0x3443C20", VA = "0x183445620")]
		private void OnTranslationControllerChangedFromState()
		{
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x0000D920 File Offset: 0x0000BB20
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x34456C0", Offset = "0x3443CC0", VA = "0x1834456C0")]
		public bool SetTranslationController(BoltEntity sourceEntity)
		{
			return default(bool);
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x3445860", Offset = "0x3443E60", VA = "0x183445860")]
		private void SetTranslationConstraint(BoltEntity controllerEntity)
		{
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		private void SetTranslationConstraint(Transform targetTransform)
		{
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E06")]
		[Address(RVA = "0xA98840", Offset = "0xA96E40", VA = "0x180A98840")]
		private void ClearTranslationConstraint()
		{
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E07")]
		[Address(RVA = "0x3445B90", Offset = "0x3444190", VA = "0x183445B90")]
		public void SetRootTransformSynced(bool value)
		{
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x3445D80", Offset = "0x3444380", VA = "0x183445D80")]
		public ScrewStructure()
		{
		}

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureRecipe _recipe;

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected List<StructureStorage> _storageSlots;

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _canBeDismantledWhileStoringItems;

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x48")]
		private Transform _translationControllerTransform;

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x50")]
		private bool _isBusy;

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x51")]
		private bool _ignoreTranslationConstraint;

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		[FieldOffset(Offset = "0x52")]
		private bool? _currentRootTransformSyncedValue;
	}
}
