using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	[AddComponentMenu("Sons/Actions/PlayerLightFireAction")]
	public class PlayerLightFireAction : MonoBehaviour
	{
		// Token: 0x06001D73 RID: 7539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x32D9C10", Offset = "0x32D8210", VA = "0x1832D9C10")]
		public void LightFire(ILightableFire lightableFire, bool prompt = false, [Optional] Action onMovementCallback)
		{
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x32D9D30", Offset = "0x32D8330", VA = "0x1832D9D30")]
		private IEnumerator LightFireRoutine(ILightableFire lightableFire, bool prompt, Action onMovementCallback)
		{
			return null;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerLightFireAction()
		{
		}
	}
}
