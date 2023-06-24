using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Construction
{
	// Token: 0x02000205 RID: 517
	[Token(Token = "0x2000205")]
	[AddComponentMenu("Sons/Construction/Presets/SawHorse/SawHorseController")]
	public class SawHorseController : MonoBehaviour, ILoadItemReceiver
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00009704 File Offset: 0x00007904
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039D")]
		public bool IsBusy
		{
			[Token(Token = "0x6000F8A")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x612490", Offset = "0x610A90", VA = "0x180612490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0000971C File Offset: 0x0000791C
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039E")]
		public bool IsLoaded
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x2EFF410", Offset = "0x2EFDA10", VA = "0x182EFF410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x2EFF420", Offset = "0x2EFDA20", VA = "0x182EFF420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00009734 File Offset: 0x00007934
		[Token(Token = "0x1700039F")]
		public bool CanApplyTransformation
		{
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x2EFF430", Offset = "0x2EFDA30", VA = "0x182EFF430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A0")]
		public ItemInstance LoadedItem
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003A1")]
		public StructureElement LoadedElement
		{
			[Token(Token = "0x6000F91")]
			[Address(RVA = "0x2EFF450", Offset = "0x2EFDA50", VA = "0x182EFF450", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003A2")]
		private ConstructionManager Manager
		{
			[Token(Token = "0x6000F92")]
			[Address(RVA = "0x2EFF470", Offset = "0x2EFDA70", VA = "0x182EFF470")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x2EFF510", Offset = "0x2EFDB10", VA = "0x182EFF510")]
		private void Start()
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x2EFF710", Offset = "0x2EFDD10", VA = "0x182EFF710")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x2EFF850", Offset = "0x2EFDE50", VA = "0x182EFF850")]
		private void GrabEnter()
		{
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x2EFFA10", Offset = "0x2EFE010", VA = "0x182EFFA10")]
		private void GrabExit()
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x2EFFC60", Offset = "0x2EFE260", VA = "0x182EFFC60")]
		private void OnInteract(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x2EFFC60", Offset = "0x2EFE260", VA = "0x182EFFC60")]
		private void ExecuteAction()
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x2EFFCD0", Offset = "0x2EFE2D0", VA = "0x182EFFCD0")]
		private void SetActiveAction(IBranchingAction action)
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0000974C File Offset: 0x0000794C
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x2EFFDD0", Offset = "0x2EFE3D0", VA = "0x182EFFDD0", Slot = "11")]
		public bool Accepts(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00009764 File Offset: 0x00007964
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x2EFFE00", Offset = "0x2EFE400", VA = "0x182EFFE00", Slot = "8")]
		public bool TryLoad(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0000977C File Offset: 0x0000797C
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x2EFFF90", Offset = "0x2EFE590", VA = "0x182EFFF90")]
		public bool TryLoad(StructureElement prefab)
		{
			return default(bool);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00009794 File Offset: 0x00007994
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x2F00100", Offset = "0x2EFE700", VA = "0x182F00100", Slot = "9")]
		public bool TryLoad(BranchingElementData elementData, ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x2F00230", Offset = "0x2EFE830", VA = "0x182F00230")]
		private void InitLoadedElementInstance()
		{
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000097AC File Offset: 0x000079AC
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x2F00900", Offset = "0x2EFEF00", VA = "0x182F00900", Slot = "10")]
		public bool TryUnLoadItem(out ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x2F00B30", Offset = "0x2EFF130", VA = "0x182F00B30")]
		private void ClearLoadedElementInstance()
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x2F00BC0", Offset = "0x2EFF1C0", VA = "0x182F00BC0")]
		public SawHorseController()
		{
		}

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoxCollider _trigger;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_workableItemDatabase")]
		[SerializeField]
		private BranchingElementDatabase _elementDatabase;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BranchingUIController _previewUI;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _defaultTriggerSize;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x48")]
		private IItemSource _itemSource;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x50")]
		private IAimRayProvider _aimRayProvider;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x58")]
		private StructureElementItemVisualController _elementController;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x60")]
		private BranchingElementData _loadedElementData;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x68")]
		private IBranchingAction _activeAction;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x70")]
		private readonly EquipItemBranchingAction _equipItemAction;
	}
}
