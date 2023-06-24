using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Sons.StatSystem;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public abstract class AffectOverTimeStimuli : MonoBehaviourStimuliValue<List<StatAdjustment>>, IVailActorInteract
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x2B95240", Offset = "0x2B93840", VA = "0x182B95240", Slot = "27")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x2B95280", Offset = "0x2B93880", VA = "0x182B95280", Slot = "25")]
		public override void EditorValidate(StringBuilder sb)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x2B95430", Offset = "0x2B93A30", VA = "0x182B95430")]
		protected AffectOverTimeStimuli()
		{
		}
	}
}
