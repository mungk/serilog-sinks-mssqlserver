﻿using System.Data;
using Serilog.Sinks.MSSqlServer.Tests.TestUtils;
using Xunit;

namespace Serilog.Sinks.MSSqlServer.Tests.Sinks.MSSqlServer
{
    [Trait(TestCategory.TraitName, TestCategory.Unit)]
    public class SqlServerColumnTests
    {
        [Fact]
        public void DefaultsPropertyNameToColumnName()
        {
            // Arrange + act
            const string columnName = "TestColumnName";
            var sut = new SqlColumn(columnName, SqlDbType.Int);

            // Assert
            Assert.Equal(columnName, sut.PropertyName);
        }

        [Fact]
        public void StoresPropertyName()
        {
            // Arrange
            const string propertyName = "TestPropertyName";
            var sut = new SqlColumn("TestColumnName", SqlDbType.Int);

            // Act
            sut.PropertyName = propertyName;

            // Assert
            Assert.Equal(propertyName, sut.PropertyName);
        }
    }
}
