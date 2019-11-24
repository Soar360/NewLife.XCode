﻿using System;
using System.Collections.Generic;
using System.Text;
using XCode.Membership;
using Xunit;

namespace XUnitTest.XCode.Configuration
{
    public class FieldTests
    {
        [Fact(DisplayName = "基础测试")]
        public void BasicTest()
        {
            var fi = UserX._.Password;
            Assert.Equal("Password", fi.Name);
            Assert.Equal("密码", fi.DisplayName);
            Assert.Equal(typeof(String), fi.Type);
            Assert.False(fi.IsIdentity);
            Assert.False(fi.PrimaryKey);
            Assert.False(fi.Master);
            Assert.True(fi.IsNullable);
            Assert.Equal(50, fi.Length);
            Assert.True(fi.IsDataObjectField);
            Assert.Equal("Password", fi.ColumnName);
            Assert.False(fi.ReadOnly);
            Assert.NotNull(fi.Table);
            Assert.NotNull(fi.Field);
            Assert.NotNull(fi.Factory);
            Assert.Null(fi.OriField);

            Assert.True(UserX._.ID.IsIdentity);
            Assert.True(UserX._.ID.PrimaryKey);
            Assert.True(UserX._.Name.Master);
            Assert.False(UserX._.Name.IsNullable);

            fi = UserX.Meta.Table.FindByName("DepartmentName");
            Assert.NotNull(fi);
            Assert.NotNull(fi.OriField);
            Assert.Equal("DepartmentID", fi.OriField.Name);
            Assert.NotNull(fi.Map);
        }
    }
}