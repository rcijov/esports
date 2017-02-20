using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Users` (
    /// `email` varchar(10) NOT NULL DEFAULT '',
    /// `idUser` int(11) NOT NULL AUTO_INCREMENT,
    /// `idSettings` int(11) NOT NULL,
    /// `idProfile` int(11) NOT NULL,
    /// `firstName` varchar(10) DEFAULT NULL,
    /// `lastName` varchar(10) DEFAULT NULL,
    /// `status` varchar(10) DEFAULT NULL,
    /// PRIMARY KEY(`idUser`) USING BTREE,
    /// KEY `FK_Users_Settings` (`idSettings`),
    /// KEY `FK_Users_Profile` (`idProfile`),
    /// CONSTRAINT `FK_Users_Profile` FOREIGN KEY(`idProfile`) REFERENCES `Profile` (`idProfile`) ON DELETE NO ACTION ON UPDATE NO ACTION,
    /// CONSTRAINT `FK_Users_Settings` FOREIGN KEY(`idSettings`) REFERENCES `Settings` (`idSettings`) ON DELETE NO ACTION ON UPDATE NO ACTION
    /// ) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class User
    {
        /// <summary>
        /// Email of the user
        /// </summary>
        String email { get; set; }

        /// <summary>
        /// Primary key for the user
        /// </summary>
        int idUser { get; set; }

        /// <summary>
        /// Foreign key for the user settings
        /// </summary>
        int idSettings { get; set; }

        /// <summary>
        /// Primary key of the user profile
        /// </summary>
        int idProfile { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        String firstName { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        String lastName { get; set; }

        /// <summary>
        /// User status
        /// </summary>
        String status { get; set; }
    }
}
