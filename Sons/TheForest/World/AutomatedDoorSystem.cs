using System;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.World
{
	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000376")]
	public class AutomatedDoorSystem : MonoBehaviour
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x32752B0", Offset = "0x32738B0", VA = "0x1832752B0")]
		private void Awake()
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x3275310", Offset = "0x3273910", VA = "0x183275310")]
		private void Update()
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x3275440", Offset = "0x3273A40", VA = "0x183275440")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x32754E0", Offset = "0x3273AE0", VA = "0x1832754E0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x3275570", Offset = "0x3273B70", VA = "0x183275570")]
		private void OnDisable()
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x21BE6D0", Offset = "0x21BCCD0", VA = "0x1821BE6D0")]
		public void Lock()
		{
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x22BEAF0", Offset = "0x22BD0F0", VA = "0x1822BEAF0")]
		public void Unlock()
		{
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x32755B0", Offset = "0x3273BB0", VA = "0x1832755B0")]
		private void UpdateDoors()
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x3275A50", Offset = "0x3274050", VA = "0x183275A50")]
		public void StartOpening()
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x3275AE0", Offset = "0x32740E0", VA = "0x183275AE0")]
		public void StartClosing()
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x3275B70", Offset = "0x3274170", VA = "0x183275B70")]
		private void SetState(AutomatedDoorSystem.State state)
		{
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x3275570", Offset = "0x3273B70", VA = "0x183275570")]
		private void StopCurrentEvent()
		{
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x3275BF0", Offset = "0x32741F0", VA = "0x183275BF0")]
		private void StartEvent(string path)
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x3275DA0", Offset = "0x32743A0", VA = "0x183275DA0")]
		public AutomatedDoorSystem()
		{
		}

		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x20")]
		public AutomatedDoorSystem.Door[] _doors;

		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x28")]
		public string[] _tags;

		// Token: 0x040016C0 RID: 5824
		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x30")]
		public AutomatedDoorSystem.State _state;

		// Token: 0x040016C1 RID: 5825
		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x34")]
		public float _duration;

		// Token: 0x040016C2 RID: 5826
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x38")]
		public bool _locked;

		// Token: 0x040016C3 RID: 5827
		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0x39")]
		public bool _manual;

		// Token: 0x040016C4 RID: 5828
		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0x40")]
		public AutomatedDoorSystem.StateEvent[] _stateEvents;

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x48")]
		public TextMesh[] _stateTextDebugReadout;

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x50")]
		private float _alpha;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x58")]
		private EventInstance _currentEvent;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		private const string OPEN_EVENT = "event:/endgame/sfx_endgame/slide_door_open";

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		private const string CLOSE_EVENT = "event:/endgame/sfx_endgame/slide_door_close";

		// Token: 0x02000377 RID: 887
		[Token(Token = "0x2000377")]
		[Serializable]
		public class Door
		{
			// Token: 0x060017D4 RID: 6100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017D4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Door()
			{
			}

			// Token: 0x040016CA RID: 5834
			[Token(Token = "0x40016CA")]
			[FieldOffset(Offset = "0x10")]
			public Transform _door;

			// Token: 0x040016CB RID: 5835
			[Token(Token = "0x40016CB")]
			[FieldOffset(Offset = "0x18")]
			public Transform _openedPosition;

			// Token: 0x040016CC RID: 5836
			[Token(Token = "0x40016CC")]
			[FieldOffset(Offset = "0x20")]
			public Transform _closedPosition;
		}

		// Token: 0x02000378 RID: 888
		[Token(Token = "0x2000378")]
		public enum State
		{
			// Token: 0x040016CE RID: 5838
			[Token(Token = "0x40016CE")]
			Closed,
			// Token: 0x040016CF RID: 5839
			[Token(Token = "0x40016CF")]
			Closing,
			// Token: 0x040016D0 RID: 5840
			[Token(Token = "0x40016D0")]
			Opened,
			// Token: 0x040016D1 RID: 5841
			[Token(Token = "0x40016D1")]
			Opening
		}

		// Token: 0x02000379 RID: 889
		[Token(Token = "0x2000379")]
		[Serializable]
		public class StateEvent
		{
			// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017D5")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public StateEvent()
			{
			}

			// Token: 0x040016D2 RID: 5842
			[Token(Token = "0x40016D2")]
			[FieldOffset(Offset = "0x10")]
			public AutomatedDoorSystem.State _state;

			// Token: 0x040016D3 RID: 5843
			[Token(Token = "0x40016D3")]
			[FieldOffset(Offset = "0x18")]
			public UnityEvent _callback;
		}
	}
}
