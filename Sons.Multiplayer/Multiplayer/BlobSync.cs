using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Sons.BlobNetworking;

namespace Sons.Multiplayer
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public static class BlobSync
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		public static BlobTransport Transport
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x30D1A70", Offset = "0x30D0070", VA = "0x1830D1A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x30D1AC0", Offset = "0x30D00C0", VA = "0x1830D1AC0")]
		public static void MapBoltConnection(BoltConnection boltConnection, ulong token)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30D1B70", Offset = "0x30D0170", VA = "0x1830D1B70")]
		public static BoltConnection GetMatchingBoltConnection(BlobTransportRemote remote)
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30D1D20", Offset = "0x30D0320", VA = "0x1830D1D20")]
		public static BlobTransportRemote GetMatchingBlobTransportRemote(BoltConnection connection)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x30D2110", Offset = "0x30D0710", VA = "0x1830D2110")]
		public static void StartTransportForServer()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x30D23A0", Offset = "0x30D09A0", VA = "0x1830D23A0")]
		public static void StartTransportForClient(ulong accessToken, ushort blobSyncPort)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x30D2A80", Offset = "0x30D1080", VA = "0x1830D2A80")]
		public static void ShutdownBlobTransport()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x30D2C50", Offset = "0x30D1250", VA = "0x1830D2C50")]
		public static ulong OnBoltClientConnected(BoltConnection connection)
		{
			return 0UL;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x30D2E70", Offset = "0x30D1470", VA = "0x1830D2E70")]
		public static void OnBoltClientDisconnected(BoltConnection connection)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x30D3000", Offset = "0x30D1600", VA = "0x1830D3000")]
		private static ulong GenerateConnectionToken()
		{
			return 0UL;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		public static void Register<T>(byte channel, IBlobSerializer<T> serializer)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x30D3180", Offset = "0x30D1780", VA = "0x1830D3180")]
		public static void Unregister(byte channel)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x30D3200", Offset = "0x30D1800", VA = "0x1830D3200")]
		public static void Send(byte channel, BoltConnection connection)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x30D3300", Offset = "0x30D1900", VA = "0x1830D3300")]
		public static void Send(byte channel, BoltConnection[] connections)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x30D34D0", Offset = "0x30D1AD0", VA = "0x1830D34D0")]
		public static void RunTests()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x30D3930", Offset = "0x30D1F30", VA = "0x1830D3930")]
		public static void DispatchEvents()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x30D3990", Offset = "0x30D1F90", VA = "0x1830D3990")]
		private static void SendBlob(BoltConnection connection, byte[] data, byte channel)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x30D3BA0", Offset = "0x30D21A0", VA = "0x1830D3BA0")]
		private static ulong GetTokenFromBoltConnection(BoltConnection connection)
		{
			return 0UL;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x30D3C80", Offset = "0x30D2280", VA = "0x1830D3C80")]
		private static void OnBlobReceived(BlobReceive blob)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x30D3F90", Offset = "0x30D2590", VA = "0x1830D3F90")]
		private static byte[] ObjectToByteArray(object obj)
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000036")]
		private static T StreamToObject<T>(Stream ms)
		{
			return null;
		}

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<byte, BlobSync.IRegisteredSerializer> ChannelSerializer;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x8")]
		private static BlobTransport _transport;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<BoltConnection, ulong> _boltToblobSyncConnections;

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		internal interface IRegisteredSerializer
		{
			// Token: 0x06000038 RID: 56
			[Token(Token = "0x6000038")]
			bool Is(object serializer);

			// Token: 0x06000039 RID: 57
			[Token(Token = "0x6000039")]
			byte[] Serialize();

			// Token: 0x0600003A RID: 58
			[Token(Token = "0x600003A")]
			void Deserialize(Stream stream);
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		internal class RegisteredSerializer<T> : BlobSync.IRegisteredSerializer
		{
			// Token: 0x0600003B RID: 59 RVA: 0x00002100 File Offset: 0x00000300
			[Token(Token = "0x600003B")]
			public bool Is(object serializer)
			{
				return default(bool);
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600003C")]
			public byte[] Serialize()
			{
				return null;
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003D")]
			public void Deserialize(Stream stream)
			{
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003E")]
			public RegisteredSerializer()
			{
			}

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x0")]
			public IBlobSerializer<T> Serializer;
		}
	}
}
