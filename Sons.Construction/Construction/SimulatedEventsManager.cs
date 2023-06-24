using System;
using System.Collections.Generic;
using Bolt;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	[AddComponentMenu("Sons/Construction/SimulatedEventsManager")]
	public class SimulatedEventsManager : SingletonBehaviour<SimulatedEventsManager>
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2E3A9A0", Offset = "0x2E38FA0", VA = "0x182E3A9A0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2E3AB40", Offset = "0x2E39140", VA = "0x182E3AB40")]
		private void ToggleRecordSimulatedBoltEvents(bool onOff)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2E3ABD0", Offset = "0x2E391D0", VA = "0x182E3ABD0")]
		private void ToggleExecuteSimulatedBoltEvents(bool onOff)
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2E3AC70", Offset = "0x2E39270", VA = "0x182E3AC70")]
		private void ToggleExecuteCallingBoltEvent(bool onOff)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2E3AD10", Offset = "0x2E39310", VA = "0x182E3AD10")]
		private bool ClearRecordedSimulatedBoltEvents(string s)
		{
			return default(bool);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073A")]
		public void OnEvent<T>(T boltEvent, Action<T> callback) where T : Event
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073B")]
		private void Record<T>(T boltEvent, Action<T> callback) where T : Event
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073C")]
		public void ExecuteRecordedEvents<T>()
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073D")]
		public void ExecuteCallingEvent<T>(T boltEvent, Action<T> callback)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x2E3AD70", Offset = "0x2E39370", VA = "0x182E3AD70")]
		public SimulatedEventsManager()
		{
		}

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x28")]
		private bool _executing;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x2C")]
		private SimulatedEventsManager.Modes _modes;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x30")]
		private List<SimulatedEventsManager.IRecordedEvent> _events;

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		private interface IRecordedEvent
		{
			// Token: 0x0600073F RID: 1855
			[Token(Token = "0x600073F")]
			void Execute();
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		private class RecordedEvent<T> : SimulatedEventsManager.IRecordedEvent
		{
			// Token: 0x06000740 RID: 1856 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000740")]
			public void Execute()
			{
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000741")]
			public RecordedEvent()
			{
			}

			// Token: 0x04000532 RID: 1330
			[Token(Token = "0x4000532")]
			[FieldOffset(Offset = "0x0")]
			public T Event;

			// Token: 0x04000533 RID: 1331
			[Token(Token = "0x4000533")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> Callback;
		}

		// Token: 0x02000105 RID: 261
		[Token(Token = "0x2000105")]
		public enum Modes
		{
			// Token: 0x04000535 RID: 1333
			[Token(Token = "0x4000535")]
			Idle,
			// Token: 0x04000536 RID: 1334
			[Token(Token = "0x4000536")]
			Record,
			// Token: 0x04000537 RID: 1335
			[Token(Token = "0x4000537")]
			ExecuteRecordedEvents,
			// Token: 0x04000538 RID: 1336
			[Token(Token = "0x4000538")]
			ExecuteCallingEvent
		}
	}
}
