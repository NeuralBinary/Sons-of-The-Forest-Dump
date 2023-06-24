using System;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using Sons.Gui.Input;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	[AddComponentMenu("Sons/Construction/Presets/ItemLoader")]
	public class ItemLoader : MonoBehaviour
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x2EFE590", Offset = "0x2EFCB90", VA = "0x182EFE590")]
		private void Awake()
		{
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x2D5ED60", Offset = "0x2D5D360", VA = "0x182D5ED60")]
		private void OnDisable()
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x2EFE860", Offset = "0x2EFCE60", VA = "0x182EFE860")]
		private void Update()
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x2EFEA60", Offset = "0x2EFD060", VA = "0x182EFEA60")]
		private void GrabEnter()
		{
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x2EFEC20", Offset = "0x2EFD220", VA = "0x182EFEC20")]
		private void GrabExit()
		{
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x2EFEDE0", Offset = "0x2EFD3E0", VA = "0x182EFEDE0")]
		private void OnInteract(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x2EFEF40", Offset = "0x2EFD540", VA = "0x182EFEF40")]
		private void Load()
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x2EFF020", Offset = "0x2EFD620", VA = "0x182EFF020")]
		private void Unload()
		{
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x2EFF2C0", Offset = "0x2EFD8C0", VA = "0x182EFF2C0")]
		private void DropItemInstance(ItemInstance itemInstance)
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ItemLoader()
		{
		}

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _interactUI;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x28")]
		private ILoadItemReceiver _receiver;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x30")]
		private IItemSource _itemSource;
	}
}
