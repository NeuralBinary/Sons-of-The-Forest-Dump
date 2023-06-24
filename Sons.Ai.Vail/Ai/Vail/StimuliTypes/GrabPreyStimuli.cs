using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	[AddComponentMenu("Sons/Stimuli/Grab Prey Stimuli")]
	public class GrabPreyStimuli : MonoBehaviourStimuli, IVailActorInteract
	{
		// Token: 0x06000BDA RID: 3034 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x2B967D0", Offset = "0x2B94DD0", VA = "0x182B967D0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x2B96800", Offset = "0x2B94E00", VA = "0x182B96800")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x2B96880", Offset = "0x2B94E80", VA = "0x182B96880", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x2B969B0", Offset = "0x2B94FB0", VA = "0x182B969B0", Slot = "26")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x2B96D00", Offset = "0x2B95300", VA = "0x182B96D00")]
		public GrabPreyStimuli()
		{
		}

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _grabbedPosition;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private VailActor _preyActor;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _predatorGrabObject;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0xC0")]
		private CharacterJoint _joint;
	}
}
