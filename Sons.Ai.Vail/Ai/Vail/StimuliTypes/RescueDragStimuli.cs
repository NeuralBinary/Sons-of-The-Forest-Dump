using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	[AddComponentMenu("Sons/Stimuli/RescueDragStimuli")]
	public class RescueDragStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000BF4 RID: 3060 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x2B97100", Offset = "0x2B95700", VA = "0x182B97100")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x2B97130", Offset = "0x2B95730", VA = "0x182B97130")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x2B971B0", Offset = "0x2B957B0", VA = "0x182B971B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x2B972F0", Offset = "0x2B958F0", VA = "0x182B972F0")]
		public void BeginDrag(VailActor draggedByActor)
		{
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x2B973E0", Offset = "0x2B959E0", VA = "0x182B973E0")]
		public void EndDrag()
		{
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public RescueDragStimuli()
		{
		}

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RescueFriendInteraction _rescueFriendInteraction;
	}
}
