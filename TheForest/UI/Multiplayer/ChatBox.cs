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
	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2000418")]
	public class ChatBox : MonoBehaviour
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x2CDE4D0", Offset = "0x2CDD4D0", VA = "0x182CDE4D0")]
		private void Awake()
		{
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x2CDEDA0", Offset = "0x2CDDDA0", VA = "0x182CDEDA0")]
		private void SendLine(string line)
		{
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x2CDEFF0", Offset = "0x2CDDFF0", VA = "0x182CDEFF0")]
		private void Update()
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x2CDEAB0", Offset = "0x2CDDAB0", VA = "0x182CDEAB0")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x2CDEB00", Offset = "0x2CDDB00", VA = "0x182CDEB00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x2CDECD0", Offset = "0x2CDDCD0", VA = "0x182CDECD0")]
		public void RegisterPlayer(string name, NetworkId id, Color playerColor)
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x2CDEF90", Offset = "0x2CDDF90", VA = "0x182CDEF90")]
		public void UnregisterPlayer(NetworkId id)
		{
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x2CDE050", Offset = "0x2CDD050", VA = "0x182CDE050")]
		public void AddLine(NetworkId? playerId, string message, bool system)
		{
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x2CDE5E0", Offset = "0x2CDD5E0", VA = "0x182CDE5E0")]
		private void CheckAddLocalPlayer(NetworkId? playerId, out bool isFromSelf)
		{
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x2CDEB70", Offset = "0x2CDDB70", VA = "0x182CDEB70")]
		public void OnSubmit()
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x2CDE9C0", Offset = "0x2CDD9C0", VA = "0x182CDE9C0")]
		public IEnumerator Close()
		{
			return null;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x2CDEA30", Offset = "0x2CDDA30", VA = "0x182CDEA30")]
		public void ForceRefreshInput()
		{
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x2CDE8A0", Offset = "0x2CDD8A0", VA = "0x182CDE8A0")]
		private void CheckInit()
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00008058 File Offset: 0x00006258
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C3")]
		public static bool IsChatOpen
		{
			[Token(Token = "0x6001B53")]
			[Address(RVA = "0x2CDF580", Offset = "0x2CDE580", VA = "0x182CDF580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x2CDF5C0", Offset = "0x2CDE5C0", VA = "0x182CDF5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x2CDEBE0", Offset = "0x2CDDBE0", VA = "0x182CDEBE0")]
		public void RegisterLocalPlayer(NetworkId argNetworkId, Color statePlayerColor)
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x2CDF560", Offset = "0x2CDE560", VA = "0x182CDF560")]
		public ChatBox()
		{
		}

		// Token: 0x04001A88 RID: 6792
		[Token(Token = "0x4001A88")]
		private const string YouName = "You";

		// Token: 0x04001A89 RID: 6793
		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _messages;

		// Token: 0x04001A8A RID: 6794
		[Token(Token = "0x4001A8A")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField _input;

		// Token: 0x04001A8B RID: 6795
		[Token(Token = "0x4001A8B")]
		[FieldOffset(Offset = "0x30")]
		public EventSystem _eventSystem;

		// Token: 0x04001A8C RID: 6796
		[Token(Token = "0x4001A8C")]
		[FieldOffset(Offset = "0x38")]
		public ChatMessageRow _messageRowPrefab;

		// Token: 0x04001A8D RID: 6797
		[Token(Token = "0x4001A8D")]
		[FieldOffset(Offset = "0x40")]
		public float _visibleDuration;

		// Token: 0x04001A8E RID: 6798
		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x44")]
		public int _historySize;

		// Token: 0x04001A8F RID: 6799
		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<NetworkId, ChatBox.Player> _players;

		// Token: 0x04001A90 RID: 6800
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x50")]
		private Queue<ChatMessageRow> _messageRows;

		// Token: 0x04001A91 RID: 6801
		[Token(Token = "0x4001A91")]
		[FieldOffset(Offset = "0x58")]
		private float _lastInteractionTime;

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x5C")]
		private int _lastMessageId;

		// Token: 0x04001A93 RID: 6803
		[Token(Token = "0x4001A93")]
		[FieldOffset(Offset = "0x60")]
		private bool _mustOpen;

		// Token: 0x04001A94 RID: 6804
		[Token(Token = "0x4001A94")]
		[FieldOffset(Offset = "0x61")]
		private bool _mustClose;

		// Token: 0x04001A95 RID: 6805
		[Token(Token = "0x4001A95")]
		[FieldOffset(Offset = "0x62")]
		private bool _skipNextOpen;

		// Token: 0x04001A96 RID: 6806
		[Token(Token = "0x4001A96")]
		[FieldOffset(Offset = "0x68")]
		private NetworkId _localPlayerId;

		// Token: 0x04001A97 RID: 6807
		[Token(Token = "0x4001A97")]
		[FieldOffset(Offset = "0x70")]
		private bool _justCloseTheBook;

		// Token: 0x02000419 RID: 1049
		[Token(Token = "0x2000419")]
		public class Player
		{
			// Token: 0x06001B57 RID: 6999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public Player()
			{
			}

			// Token: 0x04001A99 RID: 6809
			[Token(Token = "0x4001A99")]
			[FieldOffset(Offset = "0x10")]
			public string _name;

			// Token: 0x04001A9A RID: 6810
			[Token(Token = "0x4001A9A")]
			[FieldOffset(Offset = "0x18")]
			public Color _color;
		}
	}
}
