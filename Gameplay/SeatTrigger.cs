using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006B1 RID: 1713
	[Token(Token = "0x20006B1")]
	public class SeatTrigger : MonoBehaviour
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000590")]
		public Transform SitLocation
		{
			[Token(Token = "0x6002BE1")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x17000591")]
		public bool CanFlipFacingBasedOnPlayerFacing
		{
			[Token(Token = "0x6002BE2")]
			[Address(RVA = "0x5CC180", Offset = "0x5CB180", VA = "0x1805CC180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x2DF29D0", Offset = "0x2DF19D0", VA = "0x182DF29D0")]
		private void Update()
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x2DF29C0", Offset = "0x2DF19C0", VA = "0x182DF29C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x2DF2CC0", Offset = "0x2DF1CC0", VA = "0x182DF2CC0")]
		private void SitDownInputReceived()
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x2DF2750", Offset = "0x2DF1750", VA = "0x182DF2750")]
		private void BeginSittingDown()
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x2DF2850", Offset = "0x2DF1850", VA = "0x182DF2850")]
		private bool CanSit()
		{
			return default(bool);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x2DF2C30", Offset = "0x2DF1C30", VA = "0x182DF2C30")]
		private void SetInUse(bool inUse)
		{
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x2DF2B60", Offset = "0x2DF1B60", VA = "0x182DF2B60")]
		private void RegisterInputAction()
		{
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEA")]
		[Address(RVA = "0x2DF2DF0", Offset = "0x2DF1DF0", VA = "0x182DF2DF0")]
		private void UnregisterInputAction()
		{
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0x2DF29D0", Offset = "0x2DF19D0", VA = "0x182DF29D0")]
		private void RefreshTriggers()
		{
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SeatTrigger()
		{
		}

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _canFlipFacingBasedOnPlayerFacing;

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _sitLocation;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GenericInteraction _interaction;

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SitLocationStimuli _sitLocationStimuli;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0x40")]
		private bool _isInUseByPlayer;

		// Token: 0x04002760 RID: 10080
		[Token(Token = "0x4002760")]
		[FieldOffset(Offset = "0x41")]
		private bool _registeredAction;
	}
}
