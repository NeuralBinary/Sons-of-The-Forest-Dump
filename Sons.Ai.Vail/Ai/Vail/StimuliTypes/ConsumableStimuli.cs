using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public abstract class ConsumableStimuli : MonoBehaviourStimuliValue<ConsumableData>, IVailActorInteract
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000C2")]
		protected GameObject DestroyGameObject
		{
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x2B98A90", Offset = "0x2B97090", VA = "0x182B98A90", Slot = "29")]
		public virtual string GetVailItemType()
		{
			return null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x2B98AC0", Offset = "0x2B970C0", VA = "0x182B98AC0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x2B98B80", Offset = "0x2B97180", VA = "0x182B98B80", Slot = "30")]
		public virtual void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x2B98D70", Offset = "0x2B97370", VA = "0x182B98D70", Slot = "31")]
		public virtual void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x2B990C0", Offset = "0x2B976C0", VA = "0x182B990C0")]
		public void DoConsume(VailActor vailActor, Action completedCallback)
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x2B99200", Offset = "0x2B97800", VA = "0x182B99200", Slot = "32")]
		public virtual void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x2B99260", Offset = "0x2B97860", VA = "0x182B99260", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x2B99360", Offset = "0x2B97960", VA = "0x182B99360")]
		protected void DoApply(VailActor vailActor, Action completedCallback)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x2B99550", Offset = "0x2B97B50", VA = "0x182B99550")]
		private void SelfDisable()
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x2B99760", Offset = "0x2B97D60", VA = "0x182B99760", Slot = "25")]
		public override void EditorValidate(StringBuilder sb)
		{
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x2B99AD0", Offset = "0x2B980D0", VA = "0x182B99AD0")]
		protected ConsumableStimuli()
		{
		}

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Tooltip("Set uses to -1 for unlimited uses.")]
		private int _uses;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _consumeTime;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _isBloody;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int _foodTypeAnimParam;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _destroyGameObject;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0xD4")]
		private float _lastInteracted;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0xD8")]
		private readonly Dictionary<VailActor, ConsumableStimuli.Consumer> _consumers;

		// Token: 0x02000185 RID: 389
		[Token(Token = "0x2000185")]
		private class Consumer
		{
			// Token: 0x06000C43 RID: 3139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Consumer()
			{
			}

			// Token: 0x0400085D RID: 2141
			[Token(Token = "0x400085D")]
			[FieldOffset(Offset = "0x10")]
			public float StartInteractTime;

			// Token: 0x0400085E RID: 2142
			[Token(Token = "0x400085E")]
			[FieldOffset(Offset = "0x14")]
			public bool Finished;
		}
	}
}
