using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace BoltInternal
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[Documentation(Alias = "Bolt.GlobalEventListener")]
	public abstract class GlobalEventListenerBase : MonoBehaviour, IBoltListNode
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		private object prev
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		private object next
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		private object list
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x8D1B30", Offset = "0x8D0130", VA = "0x1808D1B30")]
		protected void OnEnable()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x8D1C00", Offset = "0x8D0200", VA = "0x1808D1C00")]
		protected void OnDisable()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
		public virtual bool PersistBetweenStartupAndShutdown()
		{
			return default(bool);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public virtual void BoltShutdownBegin(AddCallback registerDoneCallback)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x8D1CD0", Offset = "0x8D02D0", VA = "0x1808D1CD0")]
		internal static void BoltShutdownBeginInvoke(AddCallback registerDoneCallback)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public virtual void BoltStartBegin()
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x8D1E40", Offset = "0x8D0440", VA = "0x1808D1E40")]
		internal static void BoltStartBeginInvoke()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public virtual void BoltStartDone()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x8D1FB0", Offset = "0x8D05B0", VA = "0x1808D1FB0")]
		internal static void BoltStartDoneInvoke()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public virtual void BoltStartFailed()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x8D2120", Offset = "0x8D0720", VA = "0x1808D2120")]
		internal static void BoltStartFailedInvoke()
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public virtual void StreamDataReceived(BoltConnection connection, UdpStreamData data)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x8D2290", Offset = "0x8D0890", VA = "0x1808D2290")]
		internal static void StreamDataReceivedInvoke(BoltConnection connection, UdpStreamData data)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void PortMappingChanged(INatDevice device, IPortMapping portMapping)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x8D2420", Offset = "0x8D0A20", VA = "0x1808D2420")]
		internal static void PortMappingChangedInvoke(INatDevice device, IPortMapping portMapping)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public virtual void SceneLoadLocalBegin(string map)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x8D25B0", Offset = "0x8D0BB0", VA = "0x1808D25B0")]
		internal static void SceneLoadLocalBeginInvoke(string map)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		public virtual void SceneLoadLocalBegin(string scene, IProtocolToken token)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x8D2720", Offset = "0x8D0D20", VA = "0x1808D2720")]
		internal static void SceneLoadLocalBeginInvoke(string scene, IProtocolToken token)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		public virtual void SceneLoadLocalDone(string map)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x8D28B0", Offset = "0x8D0EB0", VA = "0x1808D28B0")]
		internal static void SceneLoadLocalDoneInvoke(string map)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public virtual void SceneLoadLocalDone(string scene, IProtocolToken token)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x8D2A20", Offset = "0x8D1020", VA = "0x1808D2A20")]
		internal static void SceneLoadLocalDoneInvoke(string scene, IProtocolToken token)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		public virtual void SceneLoadRemoteDone(BoltConnection connection)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x8D2BB0", Offset = "0x8D11B0", VA = "0x1808D2BB0")]
		internal static void SceneLoadRemoteDoneInvoke(BoltConnection connection)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "22")]
		public virtual void SceneLoadRemoteDone(BoltConnection connection, IProtocolToken token)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x8D2D20", Offset = "0x8D1320", VA = "0x1808D2D20")]
		internal static void SceneLoadRemoteDoneInvoke(BoltConnection connection, IProtocolToken token)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		public virtual void Connected(BoltConnection connection)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x8D2EB0", Offset = "0x8D14B0", VA = "0x1808D2EB0")]
		internal static void ConnectedInvoke(BoltConnection connection)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "24")]
		public virtual void ConnectFailed(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x8D3020", Offset = "0x8D1620", VA = "0x1808D3020")]
		internal static void ConnectFailedInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "25")]
		public virtual void ConnectRequest(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x8D31B0", Offset = "0x8D17B0", VA = "0x1808D31B0")]
		internal static void ConnectRequestInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public virtual void ConnectRefused(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x8D3340", Offset = "0x8D1940", VA = "0x1808D3340")]
		internal static void ConnectRefusedInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public virtual void ConnectAttempt(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x8D34D0", Offset = "0x8D1AD0", VA = "0x1808D34D0")]
		internal static void ConnectAttemptInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public virtual void Disconnected(BoltConnection connection)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x8D3660", Offset = "0x8D1C60", VA = "0x1808D3660")]
		internal static void DisconnectedInvoke(BoltConnection connection)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		public virtual void ControlOfEntityLost(BoltEntity entity)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x8D37D0", Offset = "0x8D1DD0", VA = "0x1808D37D0")]
		internal static void ControlOfEntityLostInvoke(BoltEntity entity)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "30")]
		public virtual void ControlOfEntityGained(BoltEntity entity)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x8D3940", Offset = "0x8D1F40", VA = "0x1808D3940")]
		internal static void ControlOfEntityGainedInvoke(BoltEntity entity)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "31")]
		public virtual void EntityAttached(BoltEntity entity)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x8D3AB0", Offset = "0x8D20B0", VA = "0x1808D3AB0")]
		internal static void EntityAttachedInvoke(BoltEntity entity)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "32")]
		public virtual void EntityDetached(BoltEntity entity)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x8D3C20", Offset = "0x8D2220", VA = "0x1808D3C20")]
		internal static void EntityDetachedInvoke(BoltEntity entity)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "33")]
		public virtual void EntityReceived(BoltEntity entity)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x8D3D90", Offset = "0x8D2390", VA = "0x1808D3D90")]
		internal static void EntityReceivedInvoke(BoltEntity entity)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "34")]
		public virtual void EntityFrozen(BoltEntity entity)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8D3F00", Offset = "0x8D2500", VA = "0x1808D3F00")]
		internal static void EntityFrozenInvoke(BoltEntity entity)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "35")]
		public virtual void EntityThawed(BoltEntity entity)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8D4070", Offset = "0x8D2670", VA = "0x1808D4070")]
		internal static void EntityThawedInvoke(BoltEntity entity)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "36")]
		public virtual void ZeusConnectFailed(UdpEndPoint endpoint)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x8D41E0", Offset = "0x8D27E0", VA = "0x1808D41E0")]
		internal static void ZeusConnectFailedInvoke(UdpEndPoint endpoint)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "37")]
		public virtual void ZeusConnected(UdpEndPoint endpoint)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8D4350", Offset = "0x8D2950", VA = "0x1808D4350")]
		internal static void ZeusConnectedInvoke(UdpEndPoint endpoint)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "38")]
		public virtual void ZeusDisconnected(UdpEndPoint endpoint)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x8D44C0", Offset = "0x8D2AC0", VA = "0x1808D44C0")]
		internal static void ZeusDisconnectedInvoke(UdpEndPoint endpoint)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "39")]
		public virtual void ZeusNatProbeResult(NatFeatures features)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x8D4630", Offset = "0x8D2C30", VA = "0x1808D4630")]
		internal static void ZeusNatProbeResultInvoke(NatFeatures features)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "40")]
		public virtual void SessionListUpdated(Map<Guid, UdpSession> sessionList)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x8D47A0", Offset = "0x8D2DA0", VA = "0x1808D47A0")]
		internal static void SessionListUpdatedInvoke(Map<Guid, UdpSession> sessionList)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "41")]
		public virtual void SessionConnectFailed(UdpSession session, IProtocolToken token)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x8D4910", Offset = "0x8D2F10", VA = "0x1808D4910")]
		internal static void SessionConnectFailedInvoke(UdpSession session, IProtocolToken token)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected GlobalEventListenerBase()
		{
		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BoltDoubleList<GlobalEventListenerBase> callbacks;
	}
}
