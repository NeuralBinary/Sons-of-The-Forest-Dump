using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000551 RID: 1361
	[Token(Token = "0x2000551")]
	[BoltGlobalBehaviour]
	public class VoiceChatBoltListener : GlobalEventListener
	{
		// Token: 0x06002421 RID: 9249 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
		public override bool PersistBetweenStartupAndShutdown()
		{
			return default(bool);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x3381ED0", Offset = "0x33804D0", VA = "0x183381ED0")]
		private void Awake()
		{
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x33822A0", Offset = "0x33808A0", VA = "0x1833822A0")]
		private void DebugInstance()
		{
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x3382600", Offset = "0x3380C00", VA = "0x183382600", Slot = "12")]
		public override void BoltStartBegin()
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x3382800", Offset = "0x3380E00", VA = "0x183382800", Slot = "15")]
		public override void StreamDataReceived(BoltConnection connection, UdpStreamData data)
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x3382810", Offset = "0x3380E10", VA = "0x183382810")]
		public static void RecordVoice()
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x3382860", Offset = "0x3380E60", VA = "0x183382860")]
		public void RecordVoiceInternal()
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x3382C10", Offset = "0x3381210", VA = "0x183382C10")]
		private void DebugLocalRecording(uint bytesRead)
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x3382CD0", Offset = "0x33812D0", VA = "0x183382CD0")]
		private void ForwardVoiceData(byte[] data, int size, NetworkId senderNetworkId)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x3383020", Offset = "0x3381620", VA = "0x183383020")]
		private void SendVoiceData(byte[] voice, int size, BoltConnection sendTo, ulong sourceId)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x33832B0", Offset = "0x33818B0", VA = "0x1833832B0")]
		private void ReceiveVoiceData(UdpStreamData data)
		{
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x33835C0", Offset = "0x3381BC0", VA = "0x1833835C0")]
		public VoiceChatBoltListener()
		{
		}

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x0")]
		private static VoiceChatBoltListener _instance;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x8")]
		private static UdpChannelName _voiceChannel;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x38")]
		private readonly byte[] _voiceOutputBuffer;

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _localDebugging;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _debugSourceId;

		// Token: 0x0400206B RID: 8299
		[Token(Token = "0x400206B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _localDebuggingOverlap;

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		[FieldOffset(Offset = "0x50")]
		private CoopSteamVoicePlayer _voicePlayer;

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		[FieldOffset(Offset = "0x58")]
		private bool _queuedDestroyed;
	}
}
