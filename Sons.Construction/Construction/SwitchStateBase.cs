using System;
using Construction.Multiplayer;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public abstract class SwitchStateBase : MonoBehaviour, IStateSwitchReceiver
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x2E39E40", Offset = "0x2E38440", VA = "0x182E39E40", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2E39FB0", Offset = "0x2E385B0", VA = "0x182E39FB0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2E3A120", Offset = "0x2E38720", VA = "0x182E3A120")]
		private void GrabEnter()
		{
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void GrabExit()
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2E3A180", Offset = "0x2E38780", VA = "0x182E3A180")]
		private void OnInteract(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06000730 RID: 1840
		[Token(Token = "0x6000730")]
		public abstract void SwitchState(Vector3 playerPosition);

		// Token: 0x06000731 RID: 1841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected SwitchStateBase()
		{
		}
	}
}
