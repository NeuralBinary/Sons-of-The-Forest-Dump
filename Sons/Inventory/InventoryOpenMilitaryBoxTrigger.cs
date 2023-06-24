using System;
using System.Collections.Generic;
using Endnight.Utilities;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F0 RID: 1520
	[Token(Token = "0x20005F0")]
	public class InventoryOpenMilitaryBoxTrigger : MonoBehaviour
	{
		// Token: 0x06002799 RID: 10137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x33C9E60", Offset = "0x33C8460", VA = "0x1833C9E60")]
		private void OnEnable()
		{
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x33CA0C0", Offset = "0x33C86C0", VA = "0x1833CA0C0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x33CA320", Offset = "0x33C8920", VA = "0x1833CA320")]
		private void ActivateObjects(bool enabled)
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279C")]
		[Address(RVA = "0x33CA4A0", Offset = "0x33C8AA0", VA = "0x1833CA4A0")]
		public void EnableLightsEvent()
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryOpenMilitaryBoxTrigger()
		{
		}

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoxCollider _collider;

		// Token: 0x040023DD RID: 9181
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _toggledObjects;

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0x38")]
		[EventRef]
		[SerializeField]
		private string _openCaseAudioEvent;

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x40")]
		private bool _caseIsOpen;

		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		[FieldOffset(Offset = "0x48")]
		private MouseEventsProxy _mouseEventsProxy;
	}
}
