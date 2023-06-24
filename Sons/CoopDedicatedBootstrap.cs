using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EC RID: 236
[Token(Token = "0x20000EC")]
public class CoopDedicatedBootstrap : MonoBehaviour
{
	// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x366EB60", Offset = "0x366D160", VA = "0x18366EB60")]
	private void Awake()
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x366EDE0", Offset = "0x366D3E0", VA = "0x18366EDE0")]
	private void ClientRoutine(string[] args)
	{
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x366F1F0", Offset = "0x366D7F0", VA = "0x18366F1F0")]
	private void ServerRoutine(string[] args)
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x36707C0", Offset = "0x366EDC0", VA = "0x1836707C0")]
	private void ApplyCheatsAndOptions()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x3670EB0", Offset = "0x366F4B0", VA = "0x183670EB0")]
	public void LaunchDSServer()
	{
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000737")]
	[Address(RVA = "0x3671B80", Offset = "0x3670180", VA = "0x183671B80")]
	private void showServerData()
	{
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x3672560", Offset = "0x3670B60", VA = "0x183672560")]
	private void setServerData()
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x000040F8 File Offset: 0x000022F8
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x3672B60", Offset = "0x3671160", VA = "0x183672B60")]
	private bool HasOption(string[] args, string name, bool defaultState)
	{
		return default(bool);
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x3672C40", Offset = "0x3671240", VA = "0x183672C40")]
	private bool HasOption(string[] args, string name)
	{
		return default(bool);
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x3672D00", Offset = "0x3671300", VA = "0x183672D00")]
	private string GetPasswordArg(string[] args, string name, string defaultValue)
	{
		return null;
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x3672DB0", Offset = "0x36713B0", VA = "0x183672DB0")]
	private string GetStringArg(string[] args, string name, string defaultValue)
	{
		return null;
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x3672EB0", Offset = "0x36714B0", VA = "0x183672EB0")]
	private int GetIntArg(string[] args, string name, int defaultValue)
	{
		return 0;
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x3672FD0", Offset = "0x36715D0", VA = "0x183672FD0")]
	private ushort GetShortArg(string[] args, string name, ushort defaultValue)
	{
		return 0;
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073F")]
	private T StringToEnum<T>(string value)
	{
		return null;
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000740")]
	private T GetEnumArg<T>(string[] args, string name, T defaultValue)
	{
		return null;
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x3673100", Offset = "0x3671700", VA = "0x183673100")]
	public CoopDedicatedBootstrap()
	{
	}

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x20")]
	public bool UseServerArgs;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x28")]
	public string[] ServerArgs;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x30")]
	public bool UseClientArgs;

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x38")]
	public string[] ClientArgs;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x40")]
	public Canvas canvas;
}
