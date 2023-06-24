using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	internal class Entity : IBoltListNode, IPriorityCalculator, IEntityReplicationFilter
	{
		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x8DE1C0", Offset = "0x8DC7C0", VA = "0x1808DE1C0")]
		internal void TakeControl(IProtocolToken token)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x8DE260", Offset = "0x8DC860", VA = "0x1808DE260")]
		internal void TakeControlInternal(IProtocolToken token)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x8DE560", Offset = "0x8DCB60", VA = "0x1808DE560")]
		internal void ReleaseControl(IProtocolToken token)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x8DE600", Offset = "0x8DCC00", VA = "0x1808DE600")]
		internal void ReleaseControlInternal(IProtocolToken token)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x8DE910", Offset = "0x8DCF10", VA = "0x1808DE910")]
		internal void AssignControl(BoltConnection connection, IProtocolToken token)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x8DECA0", Offset = "0x8DD2A0", VA = "0x1808DECA0")]
		internal void RevokeControl(IProtocolToken token)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x8DEF20", Offset = "0x8DD520", VA = "0x1808DEF20")]
		internal bool QueueInput(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x170000D0")]
		internal int Frame
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x8DF040", Offset = "0x8DD640", VA = "0x1808DF040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x170000D1")]
		internal int SendRate
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x8DF120", Offset = "0x8DD720", VA = "0x1808DF120")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x170000D2")]
		internal bool IsSceneObject
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x8DF1B0", Offset = "0x8DD7B0", VA = "0x1808DF1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x170000D3")]
		internal bool HasParent
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x8DF210", Offset = "0x8DD810", VA = "0x1808DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x170000D4")]
		internal bool IsAttached
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x8DF280", Offset = "0x8DD880", VA = "0x1808DF280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x170000D5")]
		internal bool IsDummy
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x8DF2E0", Offset = "0x8DD8E0", VA = "0x1808DF2E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x170000D6")]
		internal bool HasControl
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x8DF310", Offset = "0x8DD910", VA = "0x1808DF310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x170000D7")]
		internal bool HasPredictedControl
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x8DF370", Offset = "0x8DD970", VA = "0x1808DF370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x170000D8")]
		public bool PersistsOnSceneLoad
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x8DF420", Offset = "0x8DDA20", VA = "0x1808DF420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x170000D9")]
		internal bool CanQueueCommands
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		private object prev
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x8DF490", Offset = "0x8DDA90", VA = "0x1808DF490", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DB")]
		private object next
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x8DF500", Offset = "0x8DDB00", VA = "0x1808DF500", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		private object list
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x8DF570", Offset = "0x8DDB70", VA = "0x1808DF570", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x8DF5D0", Offset = "0x8DDBD0", VA = "0x1808DF5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x8DF640", Offset = "0x8DDC40", VA = "0x1808DF640", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x8DF650", Offset = "0x8DDC50", VA = "0x1808DF650")]
		internal void SetParent(Entity entity)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x8DF690", Offset = "0x8DDC90", VA = "0x1808DF690")]
		internal void SetParentInternal(Entity entity)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x8DF870", Offset = "0x8DDE70", VA = "0x1808DF870")]
		internal void SetScopeAll(bool inScope)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x8DF9E0", Offset = "0x8DDFE0", VA = "0x1808DF9E0")]
		internal void SetScope(BoltConnection connection, bool inScope)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x8DFA10", Offset = "0x8DE010", VA = "0x1808DFA10")]
		internal void Freeze(bool freeze)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x8DFBD0", Offset = "0x8DE1D0", VA = "0x1808DFBD0")]
		internal EntityProxy CreateProxy()
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x8DFE90", Offset = "0x8DE490", VA = "0x1808DFE90")]
		internal void Attach()
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x8E03F0", Offset = "0x8DE9F0", VA = "0x1808E03F0")]
		internal void Detach()
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x8E0A20", Offset = "0x8DF020", VA = "0x1808E0A20")]
		internal void AddEventListener(MonoBehaviour behaviour)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x8E0A50", Offset = "0x8DF050", VA = "0x1808E0A50")]
		internal void RemoveEventListener(MonoBehaviour behaviour)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x8E0A80", Offset = "0x8DF080", VA = "0x1808E0A80")]
		internal bool IsController(BoltConnection connection)
		{
			return default(bool);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x8E0AA0", Offset = "0x8DF0A0", VA = "0x1808E0AA0")]
		internal void Render()
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x8E0AF0", Offset = "0x8DF0F0", VA = "0x1808E0AF0")]
		internal void Initialize()
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x8E1240", Offset = "0x8DF840", VA = "0x1808E1240")]
		private IEntityBehaviour[] GetIEntityBehaviours(QueryOptions queryOption)
		{
			return null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x8E15F0", Offset = "0x8DFBF0", VA = "0x1808E15F0")]
		private Component[] GetIEntityReplicationFilters(QueryOptions queryOption)
		{
			return null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x8E16C0", Offset = "0x8DFCC0", VA = "0x1808E16C0")]
		private Component[] GetIPriorityCalculators(QueryOptions queryOption)
		{
			return null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x8E1790", Offset = "0x8DFD90", VA = "0x1808E1790")]
		private Component[] GetComponents(QueryOptions queryOption, Type componentType)
		{
			return null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x8E1970", Offset = "0x8DFF70", VA = "0x1808E1970")]
		internal void SetIdle(BoltConnection connection, bool idle)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x8E1AD0", Offset = "0x8E00D0", VA = "0x1808E1AD0")]
		private void RemoveOldCommandCallbacks(int number)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x8E1BA0", Offset = "0x8E01A0", VA = "0x1808E1BA0")]
		internal void Simulate()
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x8E2440", Offset = "0x8E0A40", VA = "0x1808E2440")]
		private int ExecuteCommandsFromRemote()
		{
			return 0;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x8E28A0", Offset = "0x8E0EA0", VA = "0x1808E28A0")]
		private void ExecuteCommand(Command cmd, bool resetState)
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x8E2B30", Offset = "0x8E1130", VA = "0x1808E2B30")]
		private int UnexecutedCommandCount()
		{
			return 0;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal void InvokeOnce(Command command, CommandCallback callback, int delay)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal void InvokeRepeating(Command command, CommandCallback callback, int period)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x8E2CB0", Offset = "0x8E12B0", VA = "0x1808E2CB0")]
		internal static Entity CreateFor(PrefabId prefabId, TypeId serializerId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x8E2E60", Offset = "0x8E1460", VA = "0x1808E2E60")]
		internal static Entity CreateFor(GameObject instance, PrefabId prefabId, TypeId serializerId)
		{
			return null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x8E2EF0", Offset = "0x8E14F0", VA = "0x1808E2EF0")]
		internal static Entity CreateFor(GameObject instance, PrefabId prefabId, TypeId serializerId, EntityFlags flags)
		{
			return null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x786DC0", Offset = "0x7853C0", VA = "0x180786DC0")]
		public static implicit operator bool(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(Entity a, Entity b)
		{
			return default(bool);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(Entity a, Entity b)
		{
			return default(bool);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x170000DD")]
		private bool Always
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8E32A0", Offset = "0x8E18A0", VA = "0x1808E32A0", Slot = "10")]
		private float CalculateStatePriority(BoltConnection connection, int skipped)
		{
			return 0f;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x8E32C0", Offset = "0x8E18C0", VA = "0x1808E32C0", Slot = "11")]
		private float CalculateEventPriority(BoltConnection connection, Event evnt)
		{
			return 0f;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
		private bool AllowReplicationTo(BoltConnection connection)
		{
			return default(bool);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x8E3380", Offset = "0x8E1980", VA = "0x1808E3380")]
		public Entity()
		{
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		private const string ProfilerSimulateOnSimulateBefore = "BoltEntity.Simulate Serializer.OnSimulateBefore";

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		private const string ProfilerSimulateOnSimulateAfter = "BoltEntity.Simulate Serializer.OnSimulateAfter";

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x10")]
		private bool _canQueueCommands;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x11")]
		private bool _canQueueCallbacks;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x14")]
		internal UniqueId SceneId;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x28")]
		internal NetworkId NetworkId;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x30")]
		internal PrefabId PrefabId;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x34")]
		internal EntityFlags Flags;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 SpawnPosition;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x44")]
		internal Quaternion SpawnRotation;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x58")]
		internal Entity Parent;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x60")]
		internal BoltEntity UnityObject;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x68")]
		internal BoltConnection Source;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x70")]
		internal BoltConnection Controller;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x78")]
		internal IProtocolToken DetachToken;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x80")]
		internal IProtocolToken AttachToken;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x88")]
		internal IProtocolToken ControlLostToken;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x90")]
		internal IProtocolToken ControlGainedToken;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x98")]
		internal IEntitySerializer Serializer;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xA0")]
		internal IEntityBehaviour[] Behaviours;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0xA8")]
		internal IPriorityCalculator PriorityCalculator;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0xB0")]
		internal IEntityReplicationFilter ReplicationFilter;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0xB8")]
		internal bool IsOwner;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0xB9")]
		internal bool IsFrozen;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0xBA")]
		internal bool AutoRemoveChildEntities;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0xBB")]
		internal bool AllowFirstReplicationWhenFrozen;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0xBC")]
		internal int UpdateRate;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0xC0")]
		internal int LastFrameReceived;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0xC4")]
		internal QueryOptions QueryOptionIEntityBehaviour;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0xC8")]
		internal QueryOptions QueryOptionIPriorityCalculator;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0xCC")]
		internal QueryOptions QueryOptionIEntityReplicationFilter;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0xD0")]
		internal int AutoFreezeProxyFrames;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0xD4")]
		internal bool CanFreeze;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0xD6")]
		internal ushort CommandSequence;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0xD8")]
		internal Command CommandLastExecuted;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0xE0")]
		internal EventDispatcher EventDispatcher;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0xE8")]
		internal BoltDoubleList<Command> CommandQueue;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0xF0")]
		internal List<CommandCallbackItem> CommandCallbacks;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0xF8")]
		internal BoltDoubleList<EntityProxy> Proxies;
	}
}
