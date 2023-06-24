using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[AddComponentMenu("Sons/Ai/Vail Audio Manager")]
	public class VailAudioManager : SingletonBehaviour<VailAudioManager>
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2B58500", Offset = "0x2B56B00", VA = "0x182B58500", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2B58510", Offset = "0x2B56B10", VA = "0x182B58510")]
		private GameObject GetNoisePrefab(VailAudioManager.Noise noise)
		{
			return null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2B58580", Offset = "0x2B56B80", VA = "0x182B58580")]
		public static void SpawnNoise(Vector3 position, VailAudioManager.Noise noise, [Optional] MonoBehaviourStimuli stimuliSource, [Optional] VailActor actorSource)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2B58870", Offset = "0x2B56E70", VA = "0x182B58870")]
		private static void SendNoiseEventToServer(Vector3 position, VailAudioManager.Noise noise)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2B58A50", Offset = "0x2B57050", VA = "0x182B58A50")]
		public static void ReceiveNoiseEventFromClient(VailNoiseEvent evt)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2B58B90", Offset = "0x2B57190", VA = "0x182B58B90")]
		private void SpawnNoiseInternal(Vector3 position, VailAudioManager.Noise noise, MonoBehaviourStimuli stimuliSource, VailActor actorSource)
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2B59390", Offset = "0x2B57990", VA = "0x182B59390")]
		private void AllocatePools(int numCells)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2B595C0", Offset = "0x2B57BC0", VA = "0x182B595C0")]
		public static void SpawnEventPrefab(Vector3 position, GameObject noisePrefab, MonoBehaviourStimuli stimuliSource, VailActor actorSource)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2B59670", Offset = "0x2B57C70", VA = "0x182B59670")]
		public static void SpawnEventPrefab(Vector3 position, EventStimuli noisePrefab, [Optional] MonoBehaviourStimuli stimuliSource)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2B59770", Offset = "0x2B57D70", VA = "0x182B59770")]
		private void SpawnEventInternal(Vector3 position, GameObject noisePrefab, [Optional] MonoBehaviourStimuli stimuliSource, [Optional] VailActor actorSource)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2B598A0", Offset = "0x2B57EA0", VA = "0x182B598A0")]
		public static void SpawnBushSearchStimuli(Vector3 position)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2B599F0", Offset = "0x2B57FF0", VA = "0x182B599F0")]
		public VailAudioManager()
		{
		}

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _softNoise;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This is medium noise stimuli with smaller range")]
		[SerializeField]
		private GameObject _mediumSoftNoise;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _mediumNoise;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _loudNoise;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _veryLoudNoise;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _treeFallNoise;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _gunFireNoise;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _explosionNoise;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _logEnabled;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EventStimuli _bushSearch;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<EventStimuli>[] _eventPool;

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		public enum Noise
		{
			// Token: 0x04000619 RID: 1561
			[Token(Token = "0x4000619")]
			Soft,
			// Token: 0x0400061A RID: 1562
			[Token(Token = "0x400061A")]
			Medium,
			// Token: 0x0400061B RID: 1563
			[Token(Token = "0x400061B")]
			Loud,
			// Token: 0x0400061C RID: 1564
			[Token(Token = "0x400061C")]
			VeryLoud,
			// Token: 0x0400061D RID: 1565
			[Token(Token = "0x400061D")]
			TreeFall,
			// Token: 0x0400061E RID: 1566
			[Token(Token = "0x400061E")]
			GunFire,
			// Token: 0x0400061F RID: 1567
			[Token(Token = "0x400061F")]
			None,
			// Token: 0x04000620 RID: 1568
			[Token(Token = "0x4000620")]
			MediumSoft,
			// Token: 0x04000621 RID: 1569
			[Token(Token = "0x4000621")]
			Explosion,
			// Token: 0x04000622 RID: 1570
			[Token(Token = "0x4000622")]
			Max
		}
	}
}
