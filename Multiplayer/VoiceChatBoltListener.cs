using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	[BoltGlobalBehaviour]
	public class VoiceChatBoltListener : GlobalEventListener
	{
		// Token: 0x0600232C RID: 9004 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x600232C")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "10")]
		public override bool PersistBetweenStartupAndShutdown()
		{
			return default(bool);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232D")]
		[Address(RVA = "0x2D70B30", Offset = "0x2D6FB30", VA = "0x182D70B30")]
		private void Awake()
		{
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x2D70DD0", Offset = "0x2D6FDD0", VA = "0x182D70DD0")]
		private void DebugInstance()
		{
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x2D70D20", Offset = "0x2D6FD20", VA = "0x182D70D20", Slot = "12")]
		public override void BoltStartBegin()
		{
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002330")]
		[Address(RVA = "0x2D71A80", Offset = "0x2D70A80", VA = "0x182D71A80", Slot = "15")]
		public override void StreamDataReceived(BoltConnection connection, UdpStreamData data)
		{
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x2D718C0", Offset = "0x2D708C0", VA = "0x182D718C0")]
		public static void RecordVoice()
		{
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x2D71630", Offset = "0x2D70630", VA = "0x182D71630")]
		public void RecordVoiceInternal()
		{
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x2D71100", Offset = "0x2D70100", VA = "0x182D71100")]
		private void DebugLocalRecording(uint bytesRead)
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x2D711C0", Offset = "0x2D701C0", VA = "0x182D711C0")]
		private void ForwardVoiceData(byte[] data, int size, NetworkId senderNetworkId)
		{
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x2D71910", Offset = "0x2D70910", VA = "0x182D71910")]
		private void SendVoiceData(byte[] voice, int size, BoltConnection sendTo, ulong sourceId)
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x2D71440", Offset = "0x2D70440", VA = "0x182D71440")]
		private void ReceiveVoiceData(UdpStreamData data)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x2D71A90", Offset = "0x2D70A90", VA = "0x182D71A90")]
		public VoiceChatBoltListener()
		{
		}

		// Token: 0x04001FAC RID: 8108
		[Token(Token = "0x4001FAC")]
		[FieldOffset(Offset = "0x0")]
		private static VoiceChatBoltListener _instance;

		// Token: 0x04001FAD RID: 8109
		[Token(Token = "0x4001FAD")]
		[FieldOffset(Offset = "0x8")]
		private static UdpChannelName _voiceChannel;

		// Token: 0x04001FAE RID: 8110
		[Token(Token = "0x4001FAE")]
		[FieldOffset(Offset = "0x38")]
		private readonly byte[] _voiceOutputBuffer;

		// Token: 0x04001FAF RID: 8111
		[Token(Token = "0x4001FAF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _localDebugging;

		// Token: 0x04001FB0 RID: 8112
		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _debugSourceId;

		// Token: 0x04001FB1 RID: 8113
		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _localDebuggingOverlap;

		// Token: 0x04001FB2 RID: 8114
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x50")]
		private CoopSteamVoicePlayer _voicePlayer;

		// Token: 0x04001FB3 RID: 8115
		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x58")]
		private bool _queuedDestroyed;
	}
}
