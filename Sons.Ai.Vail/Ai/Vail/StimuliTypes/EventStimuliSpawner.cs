using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	public class EventStimuliSpawner : MonoBehaviour
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x2B9FCE0", Offset = "0x2B9E2E0", VA = "0x182B9FCE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EventStimuliSpawner()
		{
		}

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EventStimuli _source;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviourStimuli _stimuliSource;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailActor _actorSource;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _reusePrefab;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x40")]
		private EventStimuli _instance;
	}
}
