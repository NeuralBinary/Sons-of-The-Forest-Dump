using System;
using System.Collections.Generic;
using Endnight.Utilities;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	public class InventoryOpenMilitaryBoxTrigger : MonoBehaviour
	{
		// Token: 0x06002690 RID: 9872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x2DA3D40", Offset = "0x2DA2D40", VA = "0x182DA3D40")]
		private void OnEnable()
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x2DA3E80", Offset = "0x2DA2E80", VA = "0x182DA3E80")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x2DA3C10", Offset = "0x2DA2C10", VA = "0x182DA3C10")]
		private void ActivateObjects(bool enabled)
		{
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x2DA3D30", Offset = "0x2DA2D30", VA = "0x182DA3D30")]
		public void EnableLightsEvent()
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryOpenMilitaryBoxTrigger()
		{
		}

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoxCollider _collider;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _toggledObjects;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _openCaseAudioEvent;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x40")]
		private bool _caseIsOpen;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x48")]
		private MouseEventsProxy _mouseEventsProxy;
	}
}
