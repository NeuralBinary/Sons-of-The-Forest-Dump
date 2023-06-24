using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TheForest.UI.Multiplayer
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public class ChatBox : MonoBehaviour
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x32B8FB0", Offset = "0x32B75B0", VA = "0x1832B8FB0")]
		private void Awake()
		{
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x32B9290", Offset = "0x32B7890", VA = "0x1832B9290")]
		private void SendLine(string line)
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x32B9370", Offset = "0x32B7970", VA = "0x1832B9370")]
		private void Update()
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x32B9940", Offset = "0x32B7F40", VA = "0x1832B9940")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x32B9A10", Offset = "0x32B8010", VA = "0x1832B9A10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x32B9AC0", Offset = "0x32B80C0", VA = "0x1832B9AC0")]
		public void RegisterPlayer(string name, NetworkId id, Color playerColor)
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x32B9BD0", Offset = "0x32B81D0", VA = "0x1832B9BD0")]
		public void UnregisterPlayer(NetworkId id)
		{
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x32B9C30", Offset = "0x32B8230", VA = "0x1832B9C30")]
		public void AddLine(NetworkId? playerId, string message, bool system)
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x32BA300", Offset = "0x32B8900", VA = "0x1832BA300")]
		private void CheckAddLocalPlayer(NetworkId? playerId, out bool isFromSelf)
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x32BA540", Offset = "0x32B8B40", VA = "0x1832BA540")]
		public void OnSubmit()
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x32BA6B0", Offset = "0x32B8CB0", VA = "0x1832BA6B0")]
		public IEnumerator Close()
		{
			return null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x32BA740", Offset = "0x32B8D40", VA = "0x1832BA740")]
		public void ForceRefreshInput()
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x32BA7C0", Offset = "0x32B8DC0", VA = "0x1832BA7C0")]
		private void CheckInit()
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000082E0 File Offset: 0x000064E0
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CD")]
		public static bool IsChatOpen
		{
			[Token(Token = "0x6001B91")]
			[Address(RVA = "0x32BA9D0", Offset = "0x32B8FD0", VA = "0x1832BA9D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B92")]
			[Address(RVA = "0x32BAA10", Offset = "0x32B9010", VA = "0x1832BAA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x32BAA50", Offset = "0x32B9050", VA = "0x1832BAA50")]
		public void RegisterLocalPlayer(NetworkId argNetworkId, Color statePlayerColor)
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x32BAAC0", Offset = "0x32B90C0", VA = "0x1832BAAC0")]
		public ChatBox()
		{
		}

		// Token: 0x04001AAC RID: 6828
		[Token(Token = "0x4001AAC")]
		private const string YouName = "You";

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _messages;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField _input;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x30")]
		public EventSystem _eventSystem;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x38")]
		public ChatMessageRow _messageRowPrefab;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x40")]
		public float _visibleDuration;

		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x44")]
		public int _historySize;

		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<NetworkId, ChatBox.Player> _players;

		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x50")]
		private Queue<ChatMessageRow> _messageRows;

		// Token: 0x04001AB5 RID: 6837
		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x58")]
		private float _lastInteractionTime;

		// Token: 0x04001AB6 RID: 6838
		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x5C")]
		private int _lastMessageId;

		// Token: 0x04001AB7 RID: 6839
		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x60")]
		private bool _mustOpen;

		// Token: 0x04001AB8 RID: 6840
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x61")]
		private bool _mustClose;

		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x62")]
		private bool _skipNextOpen;

		// Token: 0x04001ABA RID: 6842
		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x68")]
		private NetworkId _localPlayerId;

		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x70")]
		private bool _justCloseTheBook;

		// Token: 0x0200040B RID: 1035
		[Token(Token = "0x200040B")]
		public class Player
		{
			// Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B95")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Player()
			{
			}

			// Token: 0x04001ABD RID: 6845
			[Token(Token = "0x4001ABD")]
			[FieldOffset(Offset = "0x10")]
			public string _name;

			// Token: 0x04001ABE RID: 6846
			[Token(Token = "0x4001ABE")]
			[FieldOffset(Offset = "0x18")]
			public Color _color;
		}
	}
}
