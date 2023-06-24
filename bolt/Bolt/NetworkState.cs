using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	internal abstract class NetworkState : NetworkObj_Root, IEntitySerializer, IState, IDisposable
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000107")]
		public Animator Animator
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x8EE6D0", Offset = "0x8ECCD0", VA = "0x1808EE6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000108")]
		internal sealed override NetworkStorage Storage
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x8EE750", Offset = "0x8ECD50", VA = "0x1808EE750", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8EE7A0", Offset = "0x8ECDA0", VA = "0x1808EE7A0")]
		internal NetworkState(NetworkState_Meta meta)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8EEAD0", Offset = "0x8ED0D0", VA = "0x1808EEAD0")]
		public void SetAnimator(Animator animator)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x8EEBF0", Offset = "0x8ED1F0", VA = "0x1808EEBF0")]
		public void AddAnimator(Animator animator)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x17000109")]
		private TypeId TypeId
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x8EECD0", Offset = "0x8ED2D0", VA = "0x1808EECD0", Slot = "5")]
			get
			{
				return default(TypeId);
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x8EECF0", Offset = "0x8ED2F0", VA = "0x1808EECF0", Slot = "6")]
		private void OnRender()
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8EEE40", Offset = "0x8ED440", VA = "0x1808EEE40", Slot = "7")]
		private void OnInitialized()
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560", Slot = "8")]
		private void OnCreated(Entity entity)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8EF010", Offset = "0x8ED610", VA = "0x1808EF010", Slot = "9")]
		private void OnParentChanging(Entity newParent, Entity oldParent)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x8EF150", Offset = "0x8ED750", VA = "0x1808EF150", Slot = "10")]
		private void OnSimulateBefore()
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8EF630", Offset = "0x8EDC30", VA = "0x1808EF630", Slot = "11")]
		private void OnSimulateAfter()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8EF780", Offset = "0x8EDD80", VA = "0x1808EF780", Slot = "12")]
		private void OnControlGained()
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x8EF980", Offset = "0x8EDF80", VA = "0x1808EF980", Slot = "13")]
		private void OnControlLost()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "14")]
		private BitSet GetDefaultMask()
		{
			return null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x8EF9F0", Offset = "0x8EDFF0", VA = "0x1808EF9F0", Slot = "15")]
		private BitSet GetFilter(BoltConnection connection, EntityProxy proxy)
		{
			return null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8EFA70", Offset = "0x8EE070", VA = "0x1808EFA70", Slot = "16")]
		private void DebugInfo()
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x8F0080", Offset = "0x8EE680", VA = "0x1808F0080")]
		private string FixArrayIndices(string path, int[] indices)
		{
			return null;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x8F0290", Offset = "0x8EE890", VA = "0x1808F0290", Slot = "17")]
		private void InitProxy(EntityProxy p)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x8F0380", Offset = "0x8EE980", VA = "0x1808F0380", Slot = "18")]
		private int Pack(BoltConnection connection, UdpPacket stream, EntityProxyEnvelope env)
		{
			return 0;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x8F0780", Offset = "0x8EED80", VA = "0x1808F0780")]
		private void PackProperties(BoltConnection connection, UdpPacket packet, EntityProxyEnvelope env, Priority[] priority, int count)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x8F0B20", Offset = "0x8EF120", VA = "0x1808F0B20", Slot = "19")]
		private void Read(BoltConnection connection, UdpPacket packet, int frame)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x8F1050", Offset = "0x8EF650", VA = "0x1808F1050")]
		private bool VerifyCallbackPath(string path)
		{
			return default(bool);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010A")]
		private Animator Animator
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x8F10C0", Offset = "0x8EF6C0", VA = "0x1808F10C0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010B")]
		private IEnumerable<Animator> AllAnimators
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x8F1130", Offset = "0x8EF730", VA = "0x1808F1130", Slot = "23")]
		private void AddAnimator(Animator animator)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x8F11D0", Offset = "0x8EF7D0", VA = "0x1808F11D0", Slot = "22")]
		private void SetAnimator(Animator animator)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x8F12A0", Offset = "0x8EF8A0", VA = "0x1808F12A0", Slot = "24")]
		private void AddCallback(string path, PropertyCallback callback)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x8F1480", Offset = "0x8EFA80", VA = "0x1808F1480", Slot = "25")]
		private void AddCallback(string path, PropertyCallbackSimple callback)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x8F1660", Offset = "0x8EFC60", VA = "0x1808F1660", Slot = "26")]
		private void RemoveCallback(string path, PropertyCallback callback)
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8F1700", Offset = "0x8EFD00", VA = "0x1808F1700", Slot = "27")]
		private void RemoveCallback(string path, PropertyCallbackSimple callback)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x8F17A0", Offset = "0x8EFDA0", VA = "0x1808F17A0", Slot = "28")]
		private void SetDynamic(string property, object value)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8F18E0", Offset = "0x8EFEE0", VA = "0x1808F18E0", Slot = "29")]
		private object GetDynamic(string property)
		{
			return null;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "30")]
		private void Dispose()
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8F1A60", Offset = "0x8F0060", VA = "0x1808F1A60")]
		private void InvokeCallbacks()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x8F1D90", Offset = "0x8F0390", VA = "0x1808F1D90")]
		private void InvokeCallbacksForProperty(int propertyIndex)
		{
		}

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x40")]
		internal Entity Entity;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x48")]
		internal List<Animator> Animators;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x50")]
		internal new NetworkState_Meta Meta;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x58")]
		internal BitSet PropertyDefaultMask;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x60")]
		internal Priority[] PropertyPriorityTemp;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x68")]
		internal BoltDoubleList<NetworkStorage> Frames;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, List<PropertyCallback>> Callbacks;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, List<PropertyCallbackSimple>> CallbacksSimple;
	}
}
