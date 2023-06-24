using System;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	[AddComponentMenu("Sons/Gameplay/ManualBurnBody")]
	public class ManualBurnBody : MonoBehaviour
	{
		// Token: 0x06003406 RID: 13318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x34C3AB0", Offset = "0x34C20B0", VA = "0x1834C3AB0")]
		private void Update()
		{
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x34C3C20", Offset = "0x34C2220", VA = "0x1834C3C20")]
		private void OnEnable()
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x34C3C30", Offset = "0x34C2230", VA = "0x1834C3C30")]
		private void OnDisable()
		{
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x34C3C40", Offset = "0x34C2240", VA = "0x1834C3C40")]
		private void GrabEnter()
		{
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void GrabExit()
		{
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340C")]
		[Address(RVA = "0x34C3C80", Offset = "0x34C2280", VA = "0x1834C3C80")]
		private void ToggleIcons(bool enablePickup)
		{
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ManualBurnBody()
		{
		}

		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BurnableBody _burnableBody;

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _sheenIcon;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pickupIcon;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly InputSystem.Action BurnAction;

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0x38")]
		private bool _isLightingFire;
	}
}
