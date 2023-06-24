using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public abstract class TimeOfDayBehaviour : MonoBehaviour, ITimeOfDayReceiver
	{
		// Token: 0x06000099 RID: 153
		[Token(Token = "0x6000099")]
		public abstract void UpdateTime(TimeOfDay time, TimeOfDay realTime);

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2D35CE0", Offset = "0x2D342E0", VA = "0x182D35CE0", Slot = "7")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9C5820", Offset = "0x9C3E20", VA = "0x1809C5820")]
		public void SetEnabled(bool value)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2D35CF0", Offset = "0x2D342F0", VA = "0x182D35CF0", Slot = "5")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0", Slot = "6")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		protected virtual void AwakeHook()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		protected virtual void OnDestroyHook()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2D35DA0", Offset = "0x2D343A0", VA = "0x182D35DA0")]
		protected internal void Awake()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2D35E20", Offset = "0x2D34420", VA = "0x182D35E20")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2D2D8D0", Offset = "0x2D2BED0", VA = "0x182D2D8D0")]
		protected TimeOfDayBehaviour()
		{
		}

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoRegister;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _enabled;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _minFrameBetweenUpdate;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _runTimeSliced;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x2C")]
		private int _lastFrameUpdated;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x30")]
		private float _lastTimeUpdated;
	}
}
