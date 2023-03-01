using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	[AddComponentMenu("Sons/Actions/PlayerLightFireAction")]
	public class PlayerLightFireAction : MonoBehaviour
	{
		// Token: 0x06001D31 RID: 7473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x2CFE7A0", Offset = "0x2CFD7A0", VA = "0x182CFE7A0")]
		public void LightFire(ILightableFire lightableFire, bool prompt = false, [Optional] Action onMovementCallback)
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x2CFE700", Offset = "0x2CFD700", VA = "0x182CFE700")]
		private IEnumerator LightFireRoutine(ILightableFire lightableFire, bool prompt, Action onMovementCallback)
		{
			return null;
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerLightFireAction()
		{
		}
	}
}
