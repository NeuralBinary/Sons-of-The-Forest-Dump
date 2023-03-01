using System;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	[AddComponentMenu("Sons/Gameplay/ManualBurnBody")]
	public class ManualBurnBody : MonoBehaviour
	{
		// Token: 0x06002A09 RID: 10761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
		private void Awake()
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x2DD2820", Offset = "0x2DD1820", VA = "0x182DD2820")]
		private void Update()
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x2DD2790", Offset = "0x2DD1790", VA = "0x182DD2790")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x2DD2750", Offset = "0x2DD1750", VA = "0x182DD2750")]
		private void OnDisable()
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x2DD2710", Offset = "0x2DD1710", VA = "0x182DD2710")]
		private void GrabEnter()
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
		private void GrabExit()
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x2DD27D0", Offset = "0x2DD17D0", VA = "0x182DD27D0")]
		private void ToggleIcons(bool enablePickup)
		{
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ManualBurnBody()
		{
		}

		// Token: 0x0400258C RID: 9612
		[Token(Token = "0x400258C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BurnableBody _burnableBody;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _sheenIcon;

		// Token: 0x0400258E RID: 9614
		[Token(Token = "0x400258E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pickupIcon;

		// Token: 0x0400258F RID: 9615
		[Token(Token = "0x400258F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly InputSystem.Action BurnAction;

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[FieldOffset(Offset = "0x38")]
		private bool _isLightingFire;
	}
}
