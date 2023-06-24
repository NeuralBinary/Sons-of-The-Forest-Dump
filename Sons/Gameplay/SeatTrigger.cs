using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public class SeatTrigger : MonoBehaviour
	{
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CD")]
		public Transform SitLocation
		{
			[Token(Token = "0x600369C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x00010560 File Offset: 0x0000E760
		[Token(Token = "0x170006CE")]
		public bool CanFlipFacingBasedOnPlayerFacing
		{
			[Token(Token = "0x600369D")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369E")]
		[Address(RVA = "0x352EFD0", Offset = "0x352D5D0", VA = "0x18352EFD0")]
		private void Update()
		{
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369F")]
		[Address(RVA = "0x352EFE0", Offset = "0x352D5E0", VA = "0x18352EFE0")]
		private void OnDisable()
		{
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x352EFF0", Offset = "0x352D5F0", VA = "0x18352EFF0")]
		private void SitDownInputReceived()
		{
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A1")]
		[Address(RVA = "0x352F030", Offset = "0x352D630", VA = "0x18352F030")]
		private void BeginSittingDown()
		{
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00010578 File Offset: 0x0000E778
		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x352F1F0", Offset = "0x352D7F0", VA = "0x18352F1F0")]
		private bool CanSit()
		{
			return default(bool);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x352F480", Offset = "0x352DA80", VA = "0x18352F480")]
		private void SetInUse(bool inUse)
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x352F570", Offset = "0x352DB70", VA = "0x18352F570")]
		private void RegisterInputAction()
		{
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x352F6A0", Offset = "0x352DCA0", VA = "0x18352F6A0")]
		private void UnregisterInputAction()
		{
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x352F7D0", Offset = "0x352DDD0", VA = "0x18352F7D0")]
		private void RefreshTriggers()
		{
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SeatTrigger()
		{
		}

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _canFlipFacingBasedOnPlayerFacing;

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _sitLocation;

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GenericInteraction _interaction;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SitLocationStimuli _sitLocationStimuli;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x40")]
		private bool _isInUseByPlayer;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x41")]
		private bool _registeredAction;
	}
}
