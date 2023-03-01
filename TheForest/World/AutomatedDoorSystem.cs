using System;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.World
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	public class AutomatedDoorSystem : MonoBehaviour
	{
		// Token: 0x0600178B RID: 6027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x2CAD440", Offset = "0x2CAC440", VA = "0x182CAD440")]
		private void Awake()
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x2CADBB0", Offset = "0x2CACBB0", VA = "0x182CADBB0")]
		private void Update()
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x2CAD4B0", Offset = "0x2CAC4B0", VA = "0x182CAD4B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x2CAD550", Offset = "0x2CAC550", VA = "0x182CAD550")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x2CAD470", Offset = "0x2CAC470", VA = "0x182CAD470")]
		private void OnDisable()
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x22C9E00", Offset = "0x22C8E00", VA = "0x1822C9E00")]
		public void Lock()
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x22CA110", Offset = "0x22C9110", VA = "0x1822CA110")]
		public void Unlock()
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x2CAD8F0", Offset = "0x2CAC8F0", VA = "0x182CAD8F0")]
		private void UpdateDoors()
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001793")]
		[Address(RVA = "0x2CAD830", Offset = "0x2CAC830", VA = "0x182CAD830")]
		public void StartOpening()
		{
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x2CAD660", Offset = "0x2CAC660", VA = "0x182CAD660")]
		public void StartClosing()
		{
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001795")]
		[Address(RVA = "0x2CAD5E0", Offset = "0x2CAC5E0", VA = "0x182CAD5E0")]
		private void SetState(AutomatedDoorSystem.State state)
		{
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x2CAD470", Offset = "0x2CAC470", VA = "0x182CAD470")]
		private void StopCurrentEvent()
		{
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x2CAD720", Offset = "0x2CAC720", VA = "0x182CAD720")]
		private void StartEvent(string path)
		{
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x2CADC50", Offset = "0x2CACC50", VA = "0x182CADC50")]
		public AutomatedDoorSystem()
		{
		}

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		[FieldOffset(Offset = "0x20")]
		public AutomatedDoorSystem.Door[] _doors;

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		[FieldOffset(Offset = "0x28")]
		public string[] _tags;

		// Token: 0x040016A1 RID: 5793
		[Token(Token = "0x40016A1")]
		[FieldOffset(Offset = "0x30")]
		public AutomatedDoorSystem.State _state;

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		[FieldOffset(Offset = "0x34")]
		public float _duration;

		// Token: 0x040016A3 RID: 5795
		[Token(Token = "0x40016A3")]
		[FieldOffset(Offset = "0x38")]
		public bool _locked;

		// Token: 0x040016A4 RID: 5796
		[Token(Token = "0x40016A4")]
		[FieldOffset(Offset = "0x39")]
		public bool _manual;

		// Token: 0x040016A5 RID: 5797
		[Token(Token = "0x40016A5")]
		[FieldOffset(Offset = "0x40")]
		public AutomatedDoorSystem.StateEvent[] _stateEvents;

		// Token: 0x040016A6 RID: 5798
		[Token(Token = "0x40016A6")]
		[FieldOffset(Offset = "0x48")]
		public TextMesh[] _stateTextDebugReadout;

		// Token: 0x040016A7 RID: 5799
		[Token(Token = "0x40016A7")]
		[FieldOffset(Offset = "0x50")]
		private float _alpha;

		// Token: 0x040016A8 RID: 5800
		[Token(Token = "0x40016A8")]
		[FieldOffset(Offset = "0x58")]
		private EventInstance _currentEvent;

		// Token: 0x040016A9 RID: 5801
		[Token(Token = "0x40016A9")]
		private const string OPEN_EVENT = "event:/endgame/sfx_endgame/slide_door_open";

		// Token: 0x040016AA RID: 5802
		[Token(Token = "0x40016AA")]
		private const string CLOSE_EVENT = "event:/endgame/sfx_endgame/slide_door_close";

		// Token: 0x02000385 RID: 901
		[Token(Token = "0x2000385")]
		[Serializable]
		public class Door
		{
			// Token: 0x06001799 RID: 6041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001799")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public Door()
			{
			}

			// Token: 0x040016AB RID: 5803
			[Token(Token = "0x40016AB")]
			[FieldOffset(Offset = "0x10")]
			public Transform _door;

			// Token: 0x040016AC RID: 5804
			[Token(Token = "0x40016AC")]
			[FieldOffset(Offset = "0x18")]
			public Transform _openedPosition;

			// Token: 0x040016AD RID: 5805
			[Token(Token = "0x40016AD")]
			[FieldOffset(Offset = "0x20")]
			public Transform _closedPosition;
		}

		// Token: 0x02000386 RID: 902
		[Token(Token = "0x2000386")]
		public enum State
		{
			// Token: 0x040016AF RID: 5807
			[Token(Token = "0x40016AF")]
			Closed,
			// Token: 0x040016B0 RID: 5808
			[Token(Token = "0x40016B0")]
			Closing,
			// Token: 0x040016B1 RID: 5809
			[Token(Token = "0x40016B1")]
			Opened,
			// Token: 0x040016B2 RID: 5810
			[Token(Token = "0x40016B2")]
			Opening
		}

		// Token: 0x02000387 RID: 903
		[Token(Token = "0x2000387")]
		[Serializable]
		public class StateEvent
		{
			// Token: 0x0600179A RID: 6042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600179A")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public StateEvent()
			{
			}

			// Token: 0x040016B3 RID: 5811
			[Token(Token = "0x40016B3")]
			[FieldOffset(Offset = "0x10")]
			public AutomatedDoorSystem.State _state;

			// Token: 0x040016B4 RID: 5812
			[Token(Token = "0x40016B4")]
			[FieldOffset(Offset = "0x18")]
			public UnityEvent _callback;
		}
	}
}
